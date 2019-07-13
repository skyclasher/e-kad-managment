using ECardManagment.Framework.Helpers;
using Microsoft.Extensions.Options;
using System.Text;

namespace ECardManagment.Process.API
{
    public abstract class BaseProcessController
    {
        private readonly IOptions<AppSettings> _setting;

        protected virtual string WebAPIUrl => _setting.Value.WebAPIUrl;
        protected virtual string AuthWebAPIUrl => _setting.Value.AuthWebAPIUrl;

        //protected virtual string SharedFolder => _setting.SharedFolder;

        protected BaseProcessController(IOptions<AppSettings> setting)
        {
            _setting = setting;
        }

        protected string GetApiUrl(string path, bool isAuthAPI = false, params string[] parameters)
        {
            StringBuilder str = new StringBuilder();
            if (isAuthAPI)
                str.Append(AuthWebAPIUrl);
            else
                str.Append(WebAPIUrl);

            str.Append(path);

            for (int i = 0; i < parameters.Length; i++)
            {
                str.Replace("{" + i + "}", parameters[i]);
            }

            return str.ToString();
        }

        //protected List<SelectListItem> DefaultSelectListItem
        //{
        //    get
        //    {
        //        return Enumerable.Repeat(new SelectListItem
        //        {
        //            Value = "-1",
        //            Text = "Please select"
        //        }, count: 1).ToList();
        //    }
        //}
    }
}
