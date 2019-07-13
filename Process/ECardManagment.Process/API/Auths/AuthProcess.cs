using AutoMapper;
using ECardManagment.Framework.Constants;
using ECardManagment.Framework.Helpers;
using ECardManagment.ViewModel.Users;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project.Framework.Exceptions;
using Project.Framework.Helper;
using Project.Framework.Sessions;
using Project.Framework.WebService;
using System;
using System.Linq;
using System.Net;
using ProjectConstant = Project.Framework.Constants;

namespace ECardManagment.Process.API.Auths
{
    public class AuthProcess : BaseProcessController, IAuthProcess
    {
        private readonly IWebServiceExecutorFactory _serviceFactory;
        private readonly IMapper _mapper;

        public AuthProcess(IOptions<AppSettings> setting, IWebServiceExecutorFactory service, IMapper mapper)
            : base(setting)
        {
            _serviceFactory = service;
            _mapper = mapper;

        }

        public ClaimVM GetClaimDetails(string token)
        {
            ClaimVM claimVM = new ClaimVM();
            string result = string.Empty;

            IWebServiceResponse response;

            IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.BearerToken.Value, token);

            try
            {
                response = service.ExecuteRequest
                    (
                        GetApiUrl
                        (
                            Constant.Api.Path.GetClaimDetails
                        ),
                        HttpMethod.GET
                    );
            }
            catch (WebServiceException ex)
            {
                throw new ProcessException(ProjectConstant.Constant.Message.Error.WebService.WebServiceFailure, ex);
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = response.RawContent;
                dynamic data = JsonConvert.DeserializeObject(result);
                claimVM = _mapper.Map<JObject, ClaimVM>(JObject.Parse(data));

                //put important identity key into session
                UserSession.UserId = Int32.Parse(claimVM.ClaimDetail.Where(i => i.Type == ProjectConstant.Constant.Claim.User.Id).FirstOrDefault().Value);
                UserSession.Username = claimVM.ClaimDetail.Where(i => i.Type == ProjectConstant.Constant.Claim.User.UserName).FirstOrDefault().Value;
                UserSession.Name = claimVM.ClaimDetail.Where(i => i.Type == ProjectConstant.Constant.Claim.User.Name).FirstOrDefault().Value;

            }
            else
            {
                throw new ProcessException(response.StatusCode, ProjectConstant.Constant.Message.Error.WebService.WebServiceError);
            }
            return claimVM;
        }

        public WebUserVM GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public WebUserVM GetUserById(string ID_WebUser)
        {
            throw new NotImplementedException();
        }

        public string Login(WebUserVM webUserVM)
        {
            TokenResponseModel result = new TokenResponseModel();

            IWebServiceResponse response;

            IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.Basic.Value);

            try
            {
                response = service.ExecuteTokenRequest
                    (
                        GetApiUrl
                        (
                            Constant.Api.Path.TokenLogin, true
                        ),
                        string.Format("username={0}&password={1}&grant_type={2}", webUserVM.Username, webUserVM.Password, "password")
                    );
            }
            catch (WebServiceException ex)
            {
                ElmahHelper.LogMessage(ex);
                throw new ProcessException(ProjectConstant.Constant.Message.Error.WebService.WebServiceFailure, ex);
            }
            catch (Exception ex)
            {
                ElmahHelper.LogMessage(ex);
                throw new Exception(ex.Message);
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = JsonConvert.DeserializeObject<TokenResponseModel>(response.RawContent);
                UserSession.Token = result.AccessToken;
                UserSession.TokenExpiry = result.ExpiresIn.ToString();
                return result.AccessToken;
            }
            else
            {
                throw new ProcessException(response.StatusCode, ProjectConstant.Constant.Message.Error.WebService.WebServiceError);
            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(WebUserVM webUserVM)
        {
            throw new NotImplementedException();
        }

        public void SetPasswordById(WebUserVM user, string password)
        {
            throw new NotImplementedException();
        }

        public void SetUserProfileById(string userId, int idWebUserProfile, int idWebUserType)
        {
            throw new NotImplementedException();
        }
    }
}
