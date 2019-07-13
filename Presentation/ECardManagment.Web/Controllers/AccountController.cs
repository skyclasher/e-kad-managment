using ECardManagment.Process.API.Auths;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ECardManagment.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly IAuthProcess _authProcess;
        private readonly ILogger _logger;

        public AccountController(IAuthProcess authProcess, ILogger<AccountController> logger)
        {
            _authProcess = authProcess;
            _logger = logger;
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Login(WebUserVM webUserVm)
        //{
        //    _authProcess.Login(webUserVm);
        //    _logger.LogInformation("User logged In.");
        //    return RedirectToPage("/Index");
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            _authProcess.Logout();
            _logger.LogInformation("User logged out.");
            return RedirectToPage("/Index");
        }
    }
}
