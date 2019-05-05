namespace Task18
{
    using System;
    using System.Net.Mail;
    using System.Text;

    class ExtractMails
    {
        public static bool IsMail(string emailAddress)
        {
            try
            {
                MailAddress email = new MailAddress(emailAddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder emails = new StringBuilder();

            foreach (string email in text)
            {
                if(IsMail(email))
                {
                    emails.Append(email + "\n");
                }
            }
            Console.WriteLine(emails);
        }
    }
}
