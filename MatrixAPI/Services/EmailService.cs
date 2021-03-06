﻿using MatrixAPI.Models;
using MatrixAPI.Services.Contracts;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MatrixAPI.Services
{
    public class EmailService: IEmailService
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
                smtp.Port = 587;
                smtp.Host = "smtp.office365.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.FromAddress, "Chaitra@12");
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
