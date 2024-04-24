using FinalProject.Common.DTO;
using MailKit.Security;
using MimeKit;
using NPOI.HSSF.Record.Chart;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Helper
{
    public static class MailHelper
    {
        private static string _emailFrom = Properties.Settings.Default.emailFrom;
        private static string _emailHost = Properties.Settings.Default.emailHost;
        private static int _emailPort = Properties.Settings.Default.emailPort;
        private static string _emailUsername = Properties.Settings.Default.emailUsername;
        private static string _emailPassword = Properties.Settings.Default.emailPassword;
        private static SecureSocketOptions _secureSocketOptions = SecureSocketOptions.Auto;

        public static async Task<SendEmailBySMTPOutput> SendEmailBySMTP(SendEmailBySMTPInput input)
        {
            var result = new SendEmailBySMTPOutput();

            var emailMessage = new MimeMessage();
            emailMessage.From.Add(MailboxAddress.Parse(_emailFrom));
            foreach (var item in input.Recipient)
            {
                emailMessage.To.Add(MailboxAddress.Parse(item));
            }

            emailMessage.Subject = input.Title;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = input.Content,
                //ContentTransferEncoding = ContentEncoding.Base64
            };

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    await client.ConnectAsync(_emailHost, _emailPort, _secureSocketOptions);
                    await client.AuthenticateAsync(_emailUsername, _emailPassword);

                    await client.SendAsync(emailMessage);
                    result.IsSuccess = true;

                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex) //todo add another try to send email
            {
                var e = ex;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
                throw;
            }

            return result;
        }

        // Test SendEmailBySMTP
        public static SendEmailBySMTPOutput TestSendEmailBySMTP()
        {
            var content = File.ReadAllText("./Resources/email-template-1.html", encoding: Encoding.UTF8);
            content = content.Replace("@FullName", "Vi Quốc Thuận");
            var input = new SendEmailBySMTPInput()
            {
                Title = $"Test {DateTime.Now}",
                Content = content,
                Recipient = new List<string> { "ngotienhoang09@gmail.com" }
            };
            var output = MailHelper.SendEmailBySMTP(input).Result;
            
            return output;
        }
    }
}
