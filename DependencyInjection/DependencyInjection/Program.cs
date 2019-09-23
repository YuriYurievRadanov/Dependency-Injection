using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Information information = new Information(new Email());
            information.SendInformation();
            Console.ReadLine();
        }

        public class Information
        {
            Email InformationSender { get; set; }

            public Information(Email email)
            {
                InformationSender = email;
            }
            public void SendInformation()
            {
                InformationSender.Send();
            }
        }

        public class Email
        {
            public void Send()
            {
                Console.WriteLine("Notification");
            }
        }
    }
}
