using System.Threading.Tasks;

namespace ECardManagment.Web.Services.Mail
{
    public interface IMailManager
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
