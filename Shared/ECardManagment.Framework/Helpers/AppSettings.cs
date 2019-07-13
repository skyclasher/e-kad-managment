using Project.Framework.Configuration;

namespace ECardManagment.Framework.Helpers
{
    public class AppSettings : BaseAppSetting
    {
        public string Secret { get; set; }
        public string ApplicationName { get; set; }
        public int Version { get; set; }
    }
}
