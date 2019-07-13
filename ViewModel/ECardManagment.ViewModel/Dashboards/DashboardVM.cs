using ECardManagment.ViewModel.Rsvps;
using Project.Framework.Helper;
using System.Collections.Generic;

namespace ECardManagment.ViewModel.Dashboards
{
    public class DashboardVM
    {
        public RsvpChartVM RsvpChartVM { get; set; }

        public List<RsvpVM> RsvpData { get; set; }
        public PagingHelper<RsvpVM> PagedAttendRsvpData { get; set; }
    }
}
