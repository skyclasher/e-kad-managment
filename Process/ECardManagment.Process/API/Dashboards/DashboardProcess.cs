using AutoMapper;
using ECardManagment.Framework.Constants;
using ECardManagment.Framework.Helpers;
using ECardManagment.ViewModel.Dashboards;
using Microsoft.Extensions.Options;
using Project.Framework.Exceptions;
using Project.Framework.Sessions;
using Project.Framework.WebService;
using System.Net;
using ProjectConstant = Project.Framework.Constants;

namespace ECardManagment.Process.API.Dashboards
{
	public class DashboardProcess : BaseProcessController, IDashboardProcess
	{
		private readonly IWebServiceExecutorFactory _serviceFactory;
		private readonly IMapper _mapper;

		public DashboardProcess(IOptions<AppSettings> setting, IWebServiceExecutorFactory service, IMapper mapper)
			: base(setting)
		{
			_serviceFactory = service;
			_mapper = mapper;

		}


		public RsvpChartVM GetRsvpChartData(string userId)
		{
			RsvpChartVM result = new RsvpChartVM(); ;

			IWebServiceResponse<RsvpChartVM> response;

			IWebServiceExecutor service = _serviceFactory.CreateInstance(RestSharpWebServiceExecutorType.BearerToken.Value, UserSession.Token);

			try
			{
				response = service.ExecuteRequest<RsvpChartVM>
					(
						GetApiUrl
						(
							Constant.Api.Path.GetRsvpChartData, false, userId
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
