using ECardManagment.Process.API.Auths;
using ECardManagment.ViewModel.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(WebUserVM webUserVm)
        {
            _authProcess.Login(webUserVm);
            _logger.LogInformation("User logged In.");
            return RedirectToPage("/Index");
        }

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
