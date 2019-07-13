using ECardManagment.ViewModel.Users;

namespace ECardManagment.Process.API.Auths
{
    public interface IAuthProcess
    {
        WebUserVM GetUserByEmail(string email);
        WebUserVM GetUserById(string ID_WebUser);
        bool Register(WebUserVM webUserVM);
        string Login(WebUserVM webUserVM);
        void Logout();
        void SetPasswordById(WebUserVM user, string password);
        void SetUserProfileById(string userId, int idWebUserProfile, int idWebUserType);
        ClaimVM GetClaimDetails(string token);
    }
}
