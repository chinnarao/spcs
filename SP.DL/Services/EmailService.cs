using System;
using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;
using common.coremodels;
using MailKit.Security;

namespace SP.DL.Services
{
    //https://www.stevejgordon.co.uk/how-to-send-emails-in-asp-net-core-1-0
    public class EmailService : IEmailService
    {
        private const string TEXTPART = "plain";
        private const string XOAUTH2 = "XOAUTH2";
        AppSettings _AppSettings;
        public EmailService(AppSettings appSettings)
        {
            _AppSettings = appSettings;
        }
        public bool SendEmail(string emailFrom, string emailTo, string mailbody, string subject, string emailFromDisplay = "", string emailToDisplay = "")
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(emailFromDisplay, emailFrom));
            message.To.Add(new MailboxAddress(emailToDisplay, emailTo));
            message.Subject = subject;

            message.Body = new TextPart(TEXTPART)
            {
                Text = mailbody
            };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(_AppSettings.EmailSettings.Host, _AppSettings.EmailSettings.Port, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove(XOAUTH2);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(_AppSettings.EmailSettings.UserName, _AppSettings.EmailSettings.Password);

                client.Send(message);
                client.Disconnect(true);
            }
            return true;
        }

        public async Task SendEmailAsync(string emailFrom, string emailTo,  string mailbody, string subject, string emailFromDisplay = "", string emailToDisplay = "")
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(emailFromDisplay, emailFrom));
            emailMessage.To.Add(new MailboxAddress(emailToDisplay, emailTo));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = mailbody };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                //    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.LocalDomain = "some.domain.com";
                await client.ConnectAsync(_AppSettings.EmailSettings.Host, _AppSettings.EmailSettings.Port, SecureSocketOptions.None).ConfigureAwait(false);
                // Note: since we don't have an OAuth2 token, disable the XOAUTH2 authentication mechanism.
                //client.AuthenticationMechanisms.Remove(XOAUTH2);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }
    }

    public interface IEmailService
    {
        Task SendEmailAsync(string emailFrom, string emailTo, string mailbody, string subject, string emailFromDisplay = "", string emailToDisplay = "");
        bool SendEmail(string emailFrom, string emailTo, string mailbody, string subject, string emailFromDisplay = "", string emailToDisplay = "");
    }
}
