using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Microsoft.Extensions.Configuration;

namespace IdentityManager.Web.Services
{
    public class MailKitSender : IEmailClient
    {
        private readonly IConfiguration _config;

        public MailKitSender(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string emailFrom, string emailTo, string subject, string htmlMessage)
        {
            try
            {
                using SmtpClient client = new();
                var userName = _config.GetValue<string>("Email:UserName");
                var password = _config.GetValue<string>("Email:Password");

                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(emailFrom));
                message.To.Add(MailboxAddress.Parse(emailTo));

                message.Subject = subject;
                message.Body = new TextPart("html")
                {
                    Text = htmlMessage
                };

                await client.ConnectAsync("smtp.gmail.com", 587, true);
                await client.AuthenticateAsync(userName, password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
                
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
