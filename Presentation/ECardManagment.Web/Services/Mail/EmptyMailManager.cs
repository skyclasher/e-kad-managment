using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ECardManagment.Web.Services.Mail
{
    public class EmptyMailManager : IMailManager
    {
        public EmptyMailManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
