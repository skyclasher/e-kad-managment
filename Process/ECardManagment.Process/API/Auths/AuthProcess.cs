using ECardManagment.ViewModel.Users;
using Project.Framework.Constants;
using Project.Framework.Interfaces;
using Project.Framework.WebService;
using System;
using System.Net;

namespace ECardManagment.Process.API.Auths
{
    public class AuthProcess : BaseProcessController, IAuthProcess
    {
        private readonly IWebServiceExecutorFactory _serviceFactory;

        public AuthProcess(IAppSetting setting, IWebServiceExecutorFactory service)
            : base(setting)
        {
            _serviceFactory = service;
        }
        public WebUserVM GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public WebUserVM GetUserById(string ID_WebUser)
        {
            throw new NotImplementedException();
        }

        public ClaimVM Login(WebUserVM webUserVM)
        {
            ClaimVM result = new ClaimVM();

            IWebServiceResponse<ClaimVM> response;

            IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.Basic.Value);

            try
            {
                response = service.ExecuteRequest<ClaimVM>
                    (
                        GetApiUrl
                        (
                            Constant.Api.Path.Login, true
                        ),
                        HttpMethod.POST,
                        webUserVM
                    );
            }
            catch (WebServiceException ex)
            {
                throw new ProcessException(Constant.Message.Error.WebService.WebServiceFailure, ex);
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = response.Data;
            }
            else
            {
                throw new ProcessException(response.StatusCode, Constant.Message.Error.WebService.WebServiceError);
            }

            return result;
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
