namespace ECardManagment.Framework.Constants
{
	public partial class Constant
	{
		public class Api
		{
			public class Path
			{
				public const string TokenLogin = "api/Token";
				public const string GetClaimDetails = "api/Users/GetClaimDetails";
				public const string Authenticate = "api/Users/Authenticate";

				public const string GetRsvpChartData = "api/Rsvp/GetRsvpChartData/{0}";
				public const string GetRsvpByUserId = "api/Rsvp/GetRsvpByUserId/{0}";
				public const string GetPagedRsvpByUserId = "api/Rsvp/GetPagedRsvpByUserId/{0}/{1}/{2}";
				public const string GetPagedAttendRsvpByUserId = "api/Rsvp/GetPagedAttendRsvpByUserId/{0}/{1}/{2}";
				public const string GetPagedNotAttendRsvpByUserId = "api/Rsvp/GetPagedNotAttendRsvpByUserId/{0}/{1}/{2}";

			}
		}
	}
}