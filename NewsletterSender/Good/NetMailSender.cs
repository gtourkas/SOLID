using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.NewsletterSender.Good
{
    public class NetMailSender : IEmailSender
    {
        public SmtpClient Client { get; set; }

        public NetMailSender(SmtpClient client)
        {
            Client = client;
        }

        public void Send(string sender, string receipient, string subject, string content)
        {
            Client.Send(sender, receipient, subject, content);
        }
    }
}
