using System.Collections.Generic;
using System.Net.Mail;

namespace SOLID.NewsletterSender.Good
{
    public class NewsletterSender
    {
        public IEmailSender EmailSender { get; set; }

        public NewsletterSender(IEmailSender emailSender)
        {
            EmailSender = emailSender;
        }

        public void Send(string sender, IEnumerable<Receipient> receipients, string subject, string contentTemplate)
        {
            foreach (var r in receipients)
                EmailSender.Send(sender, r.EmailAddress, subject, contentTemplate.Replace("[FULL_NAME]", r.FullName));
        }
    }
}
