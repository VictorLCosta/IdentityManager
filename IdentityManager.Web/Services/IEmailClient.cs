using System;
using System.Threading.Tasks;

namespace IdentityManager.Web.Services
{
    public interface IEmailClient
    {
        Task SendEmailAsync(string emailTo, string subject, string htmlMessage);
    }
}
