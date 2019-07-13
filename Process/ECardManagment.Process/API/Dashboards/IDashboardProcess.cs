using ECardManagment.ViewModel.Dashboards;

namespace ECardManagment.Process.API.Dashboards
{
    public interface IDashboardProcess
    {
        RsvpChartVM GetRsvpChartData(string userId);
    }
}
