using System;
using System.Net.Mail;

namespace HW07.Booking.Com.Models
{
    class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public MailAddress Mail { get; set; }
        public string Name { get; private set; }
        public string Password { get; private set; }

        public User(string mail, string name, string password) => (Mail, Name, Password) = (TryCreateMail(mail), name, password);

        private MailAddress TryCreateMail(string mail)
        {
            if (!MailAddress.TryCreate(mail, out MailAddress mailAddress))
                throw new ArgumentException("Invalid mail!");
            return mailAddress;
        }

        public void ChangePassword(string newPassword) => Password = newPassword;

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user.Mail.Equals(Mail);
        }

        public override int GetHashCode() => Mail.Address.Length + Password.Length;
    }
}
