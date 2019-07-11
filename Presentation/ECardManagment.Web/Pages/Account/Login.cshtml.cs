using ECardManagment.Process.API.Auths;
using ECardManagment.ViewModel.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECardManagment.Web.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly IAuthProcess _authProcess;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(IAuthProcess authProcess, ILogger<LoginModel> logger)
        {
            _authProcess = authProcess;
            _logger = logger;
        }

        [BindProperty]
        public WebUserVM WebUserVM { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        //public class InputModel
        //{
        //    [Required]
        //    [EmailAddress]
        //    public string Email { get; set; }

        //    [Required]
        //    [DataType(DataType.Password)]
        //    public string Password { get; set; }

        //    [Display(Name = "Remember me?")]
        //    public bool RememberMe { get; set; }
        //}

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public IActionResult OnPost(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {
                ClaimVM claim = _authProcess.Login(WebUserVM);

                if (claim != null)
                {
                    if (!string.IsNullOrEmpty(claim.Token))
                    {
                        _logger.LogInformation("User logged in.");
                        return LocalRedirect(Url.GetLocalUrl(returnUrl));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Email or password is incorrect.");
                        return Page();
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Email or password is incorrect.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
