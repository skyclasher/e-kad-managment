using ECardManagment.Extensions.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ECardManagment.Web.Controllers
{
    [ValidateToken]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        public class ChangePasswordInput
        {
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Current password")]
            public string OldPassword { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordInput model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var changePasswordResult = await _userManager.ChangePasswordAsync(CurrentUser, model.OldPassword, model.NewPassword);
            //if (!changePasswordResult.Succeeded)
            //{
            //    foreach (var error in changePasswordResult.Errors)
            //    {
            //        ModelState.AddModelError(string.Empty, error.Description);
            //    }
            //    return BadRequest(ModelState);
            //}

            //await _signInManager.SignInAsync(CurrentUser, isPersistent: false);
            //_logger.LogInformation("User changed their password successfully.");

            return Ok("Your password has been changed.");
        }

        public class SetPasswordInput
        {
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetPassword(SetPasswordInput model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var addPasswordResult = await _userManager.AddPasswordAsync(CurrentUser, model.NewPassword);
            //if (!addPasswordResult.Succeeded)
            //{
            //    foreach (var error in addPasswordResult.Errors)
            //    {
            //        ModelState.AddModelError(string.Empty, error.Description);
            //    }
            //    return BadRequest(ModelState);
            //}

            //await _signInManager.SignInAsync(CurrentUser, isPersistent: false);
            //_logger.LogInformation("User set password successfully.");

            return Ok("Your password has been set.");
        }
    }
}