### Vehicle Check

##### Bad

DIP is typically violated when interacting with infrastructure. The direct instantiation of the System.Net.Mail
client within the NewsletterSender class is such a violation.

##### Good

Creating the IEmailSender abstraction that the NewsletterSender depends upon and a separate class that encapsulates
the System.Net.Email implementation. 