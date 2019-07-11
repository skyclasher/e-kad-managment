using ECardManagment.ViewModel.Users;
using Project.Framework.Interfaces;
using Project.Framework.WebService;
using System;

namespace ECardManagment.Process.API.Auths
{
    public class AuthProcess : BaseProcessController, IAuthProcess
    {
        private readonly IWebServiceExecutorFactory _serviceFactory;

        public AuthProcess(IAppSetting setting, IWebServiceExecutorFactory service)
            : base(setting)
        {
            _serviceFactory = service;
        }
        public WebUserVM GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public WebUserVM GetUserById(string ID_WebUser)
        {
            throw new NotImplementedException();
        }

        public ClaimVM Login(WebUserVM webUserVM)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(WebUserVM webUserVM)
        {
            throw new NotImplementedException();
        }

        public void SetPasswordById(WebUserVM user, string password)
        {
            throw new NotImplementedException();
        }

        public void SetUserProfileById(string userId, int idWebUserProfile, int idWebUserType)
        {
            throw new NotImplementedException();
        }
    }
}
