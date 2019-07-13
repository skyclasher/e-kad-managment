using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ECardManagment.Web.Services.Profile
{
    public class ProfileManager
    {
        IHttpContextAccessor _httpContextAccessor;

       // private ApplicationUser _currentUser;

        public ProfileManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //public ApplicationUser CurrentUser
        //{
        //    get
        //    {
        //        if (_currentUser == null)
        //            _currentUser = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;

        //        return _currentUser;
        //    }
        //}

        //public bool IsHasPassword(ApplicationUser user)
        //{
        //    return _userManager.HasPasswordAsync(user).Result;
        //}

        //public bool IsEmailConfirmed(ApplicationUser user)
        //{
        //    return _userManager.IsEmailConfirmedAsync(user).Result;
        //}
    }
}
