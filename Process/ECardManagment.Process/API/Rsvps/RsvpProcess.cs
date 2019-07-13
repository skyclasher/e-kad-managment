using AutoMapper;
using ECardManagment.Framework.Constants;
using ECardManagment.Framework.Helpers;
using ECardManagment.ViewModel.Rsvps;
using Microsoft.Extensions.Options;
using Project.Framework.Exceptions;
using Project.Framework.Helper;
using Project.Framework.Sessions;
using Project.Framework.WebService;
using System.Collections.Generic;
using System.Net;
using ProjectConstant = Project.Framework.Constants;

namespace ECardManagment.Process.API.Rsvps
{
    public class RsvpProcess : BaseProcessController, IRsvpProcess
    {
        private readonly IWebServiceExecutorFactory _serviceFactory;
        private readonly IMapper _mapper;

        public RsvpProcess(IOptions<AppSettings> setting, IWebServiceExecutorFactory service, IMapper mapper)
            : base(setting)
        {
            _serviceFactory = service;
            _mapper = mapper;

        }

        public List<RsvpVM> GetRsvpByUserId(string userId)
        {
            List<RsvpVM> result = new List<RsvpVM>(); 

            IWebServiceResponse<List<RsvpVM>> response;

            IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.BearerToken.Value, UserSession.Token);

            try
            {
                response = service.ExecuteRequest<List<RsvpVM>>
                    (
                        GetApiUrl
                        (
                            Constant.Api.Path.GetRsvpByUserId, false, userId
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
                result = response.Data;

            }
            else
            {
                throw new ProcessException(response.StatusCode, ProjectConstant.Constant.Message.Error.WebService.WebServiceError);
            }
            return result;
        }

        public PagingHelper<RsvpVM> GetPagedRsvpByUserId(string userId, string searchText, int currentPage)
        {
            PagingHelper<RsvpVM> result = new PagingHelper<RsvpVM>();

            IWebServiceResponse<PagingHelper<RsvpVM>> response;

            IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.BearerToken.Value, UserSession.Token);

            if (string.IsNullOrEmpty(searchText))
                searchText = ProjectConstant.Constant.ReplaceText.EmptyString;

            try
            {
                response = service.ExecuteRequest<PagingHelper<RsvpVM>>
                    (
                        GetApiUrl
                        (
                            Constant.Api.Path.GetPagedRsvpByUserId, false, userId, searchText, currentPage.ToString()
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
                result = response.Data;

            }
            else
            {
                throw new ProcessException(response.StatusCode, ProjectConstant.Constant.Message.Error.WebService.WebServiceError);
            }
            return result;
        }

        public PagingHelper<RsvpVM> GetPagedAttendRsvpByUserId(string userId, string searchText, int currentPage)
        {
            PagingHelper<RsvpVM> result = new PagingHelper<RsvpVM>();

            IWebServiceResponse<PagingHelper<RsvpVM>> response;

            IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.BearerToken.Value, UserSession.Token);

            if (string.IsNullOrEmpty(searchText))
                searchText = ProjectConstant.Constant.ReplaceText.EmptyString;

            try
            {
                response = service.ExecuteRequest<PagingHelper<RsvpVM>>
                    (
                        GetApiUrl
                        (
                            Constant.Api.Path.GetPagedAttendRsvpByUserId, false, userId, searchText, currentPage.ToString()
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
                result = response.Data;

            }
            else
            {
                throw new ProcessException(response.StatusCode, ProjectConstant.Constant.Message.Error.WebService.WebServiceError);
            }
            return result;
        }
    }
}
