using IT_Solutions.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System.Threading.Tasks;

namespace IT_Solutions.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> SendMessageAsync(MessageModel message)
        {
            MimeMessage msg = PrepareMesaage(message);

            return await SendViaClientAsync(msg);
        }

        private MimeMessage PrepareMesaage(MessageModel message)
        {
            MimeMessage mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress(_configuration["EmailSender:Name"], _configuration["EmailSender:Address"]));
            mailMessage.ReplyTo.Add(new MailboxAddress(message.Name, message.SenderEmail));
            mailMessage.To.Add(new MailboxAddress(_configuration["EmailSender:Name"], _configuration["EmailSender:To"]));
            mailMessage.Subject = "Contact form";
            mailMessage.Body = new TextPart("plain")
            {
                Text = message.Message
            };

            return mailMessage;
        }

        private async Task<bool> SendViaClientAsync(MimeMessage msg)
        {
            try
            {
                using (SmtpClient client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(_configuration["EmailSender:Host"], 587, false);
                    client.Authenticate(_configuration["EmailSender:Address"], _configuration["EmailSender:Password"]);
                    await client.SendAsync(msg);
                    client.Disconnect(true);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
