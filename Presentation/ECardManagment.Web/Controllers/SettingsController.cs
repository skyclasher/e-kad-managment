using ECardManagment.Extensions.Filter;
using Microsoft.AspNetCore.Mvc;

namespace ECardManagment.Web.Controllers
{
    [ValidateToken]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("/Settings/Profile");
        }

        public IActionResult TwoFactorAuth()
        {
            return RedirectToPage("/Settings/TwoFactorAuth/Config");
        }
    }
}