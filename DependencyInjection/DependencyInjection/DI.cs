using System;

namespace DependencyInjection
{
    class DI
    {
        private static void DependencyInjection(string[] args)
        {
            Information mailInformation = new Information(new Email());
            mailInformation.SendInformation();
            Console.WriteLine("----------------------------");

            Information smsInformation = new Information(new Sms());
            smsInformation.SendInformation();
            Console.ReadLine();
        }

        public class Information
        {
            private ISender InformationSender { get; set; }

            public Information(ISender informationSender)
            {
                InformationSender = informationSender;
            }
            public void SendInformation()
            {
                InformationSender.Send();
            }
        }

        public interface ISender
        {
            void Send();
        }

        public class Email : ISender
        {
            public void Send()
            {
                Console.WriteLine("Email.");
            }
        }

        public class Sms : ISender
        {
            public void Send()
            {
                Console.WriteLine("SMS.");
            }
        }
    }
}
