using ECardManagment.Extensions.Filter;
using ECardManagment.Framework.Constants;
using ECardManagment.Process.API.Dashboards;
using ECardManagment.Process.API.Rsvps;
using ECardManagment.ViewModel.Dashboards;
using ECardManagment.ViewModel.Rsvps;
using Microsoft.AspNetCore.Mvc;
using Project.Framework.Helper;
using Project.Framework.Sessions;

namespace ECardManagment.Web.Controllers
{
	[ValidateToken]
	public class DashboardsController : Controller
	{
		private readonly IDashboardProcess _dashboardProcess;
		private readonly IRsvpProcess _rspvProcess;

		public DashboardsController(IDashboardProcess dashboardProcess, IRsvpProcess rsvpProcess)
		{
			_dashboardProcess = dashboardProcess;
			_rspvProcess = rsvpProcess;
		}
		public IActionResult Dashboard2()
		{
			return RedirectToAction("Dashboard1");
		}

		public IActionResult Dashboard1()
		{
			return View();
		}

		public IActionResult Index()
		{
			string userId = UserSession.UserId;

			DashboardVM dashboardVM = new DashboardVM
			{
				RsvpChartVM = _dashboardProcess.GetRsvpChartData(userId),
				RsvpData = _rspvProcess.GetRsvpByUserId(userId),
				PagedAttendRsvpData = _rspvProcess.GetPagedAttendRsvpByUserId(userId, string.Empty, 1),
				PagedMaybeAttendRsvpData = _rspvProcess.GetPagedMaybeAttendRsvpByUserId(userId, string.Empty, 1),
				PagedNotAttendRsvpData = _rspvProcess.GetPagedNotAttendRsvpByUserId(userId, string.Empty, 1)
			};
			return View(Constant.ViewPath.Dashboard, dashboardVM);
		}


		[HttpGet]
		public ActionResult GetPagedAttendRsvp(int currentPage, string searchText)
		{
			PagingHelper<RsvpVM> pagedRsvp = _rspvProcess.GetPagedAttendRsvpByUserId(UserSession.UserId, searchText, currentPage);
			return PartialView(Constant.ViewPath.RsvpAttendListing, pagedRsvp);
		}


		[HttpGet]
		public ActionResult GetPagedMaybeAttendRsvp(int currentPage, string searchText)
		{
			PagingHelper<RsvpVM> pagedRsvp = _rspvProcess.GetPagedMaybeAttendRsvpByUserId(UserSession.UserId, searchText, currentPage);
			return PartialView(Constant.ViewPath.RsvpMaybeAttendListing, pagedRsvp);
		}


		[HttpGet]
		public ActionResult GetPagedNotAttendRsvp(int currentPage, string searchText)
		{
			PagingHelper<RsvpVM> pagedRsvp = _rspvProcess.GetPagedNotAttendRsvpByUserId(UserSession.UserId, searchText, currentPage);
			return PartialView(Constant.ViewPath.RsvpNotAttendListing, pagedRsvp);
		}

	}
}