using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MatrixWebApi.Contracts;
using MatrixWebApi.CrossCutting;
using MatrixWebApi.Models;

namespace MatrixWebApi.Services
{
    public class EmailService : IEmail
    {
        public Task<string> SendEmail(Email mail)
        {
            try
            {
                var message = new MailMessage();
                var smtp = new SmtpClient();
                message.From = new MailAddress(mail.FromAddress);
                message.To.Add(new MailAddress(mail.ToAddress));
                message.Subject = mail.Subject;
                message.IsBodyHtml = true;
                message.Body = mail.Body;
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings[Constants.AppSMTPPortKey]);
                smtp.Host = ConfigurationManager.AppSettings[Constants.AppSMTPAddressKey];
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.FromAddress, ConfigurationManager.AppSettings[Constants.AppSMTPEmailPasswordKey]);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                return Task.FromResult($"Email sent to {mail.ToAddress}");
            }
            catch (SmtpException ex)
            {
                return Task.FromResult($"Email not sent to {mail.ToAddress} due to {ex.Message}");
            }
        }
    }
}