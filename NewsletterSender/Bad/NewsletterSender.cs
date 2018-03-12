using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.NewsletterSender.Bad
{
    public class NewsletterSender
    {
        public SmtpClient Client { get; set; }

        public NewsletterSender(SmtpClient client)
        {
            Client = client;
        }

        public void Send(string sender, IEnumerable<Receipient> receipients, string subject, string contentTemplate)
        {
            foreach (var r in receipients)
                Client.Send(sender, r.EmailAddress, subject, contentTemplate.Replace("[FULL_NAME]", r.FullName));

        }
    }
}
