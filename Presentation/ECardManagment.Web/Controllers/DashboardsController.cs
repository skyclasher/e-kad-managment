using ECardManagment.Extensions.Filter;
using ECardManagment.Framework.Constants;
using ECardManagment.Process.API.Dashboards;
using ECardManagment.Process.API.Rsvps;
using ECardManagment.ViewModel.Dashboards;
using ECardManagment.ViewModel.Rsvps;
using Microsoft.AspNetCore.Mvc;
using Project.Framework.Helper;
using Project.Framework.Sessions;
using System.Collections.Generic;

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
        public IActionResult Index()
        {
            return RedirectToAction("Dashboard1");
        }

        public IActionResult Dashboard1()
        {
            return View();
        }

        public IActionResult Dashboard2()
        {
            string userId = UserSession.UserId.Value.ToString();

            DashboardVM dashboardVM = new DashboardVM();
            dashboardVM.RsvpChartVM = _dashboardProcess.GetRsvpChartData(userId);
            dashboardVM.RsvpData = _rspvProcess.GetRsvpByUserId(userId);
            dashboardVM.PagedAttendRsvpData = _rspvProcess.GetPagedAttendRsvpByUserId(userId, string.Empty, 1);
            return View(dashboardVM);
        }


        [HttpGet]
        public ActionResult GetPagedRsvp(int currentPage, string searchText)
        {
            PagingHelper<RsvpVM> pagedRsvp = _rspvProcess.GetPagedAttendRsvpByUserId(UserSession.UserId.Value.ToString(), searchText, currentPage);
            return PartialView(Constant.ViewPath.RsvpListing, pagedRsvp);
        }

    }
}