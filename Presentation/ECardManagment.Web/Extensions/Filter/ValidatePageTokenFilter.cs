using Microsoft.AspNetCore.Mvc.Filters;
using Project.Framework.Sessions;

namespace ECardManagment.Extensions.Filter
{
    public class ValidatePageTokenFilter : IPageFilter
    {
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            // do something during page handler selection.
            //if (string.IsNullOrEmpty(UserSession.Token) || DateTime.Now > DateTime.Parse(UserSession.TokenExpiry))
            if (string.IsNullOrEmpty(UserSession.Token) && context.HttpContext.Request.Path != "/Account/Login" 
                                                        && context.HttpContext.Request.Path != "/Error")
            {
                context.HttpContext.Response.Redirect("/Account/Login");
            }
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            // do something after handler selection, but before a handler method executes.
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            // do something after a handler method executes.
        }
    }
}
