using ECardManagment.ViewModel.Rsvps;
using Project.Framework.Helper;
using System.Collections.Generic;

namespace ECardManagment.Process.API.Rsvps
{
	public interface IRsvpProcess
	{
		List<RsvpVM> GetRsvpByUserId(string userId);
		PagingHelper<RsvpVM> GetPagedRsvpByUserId(string userId, string searchText, int currentPage);
		PagingHelper<RsvpVM> GetPagedAttendRsvpByUserId(string userId, string searchText, int currentPage);
		PagingHelper<RsvpVM> GetPagedNotAttendRsvpByUserId(string userId, string searchText, int currentPage);
	}
}
