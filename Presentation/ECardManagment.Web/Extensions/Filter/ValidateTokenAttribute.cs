using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Project.Framework.Sessions;

namespace ECardManagment.Extensions.Filter
{
    public class ValidateTokenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            //if (string.IsNullOrEmpty(UserSession.Token) || DateTime.Now > DateTime.Parse(UserSession.TokenExpiry))
            if (string.IsNullOrEmpty(UserSession.Token))
            {
                filterContext.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
            }
        }
    }
}
