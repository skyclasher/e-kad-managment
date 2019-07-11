using Project.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECardManagment.Process.API
{
    public abstract class BaseProcessController
    {
        private readonly IAppSetting _setting;

        protected virtual string WebAPIUrl => _setting.WebAPIUrl;
        protected virtual string AuthWebAPIUrl => _setting.AuthWebAPIUrl;

        //protected virtual string SharedFolder => _setting.SharedFolder;

        protected BaseProcessController(IAppSetting setting)
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
