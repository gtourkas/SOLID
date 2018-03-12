using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NewsletterSender.Good
{
    public interface IEmailSender
    {
        void Send(string sender, string receipient, string subject, string content);
    }
}
