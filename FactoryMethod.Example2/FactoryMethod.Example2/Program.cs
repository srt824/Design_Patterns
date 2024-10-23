using FactoryMethod.Example2.Factories;

namespace FactoryMethod.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPlease choose a notification type: (1) Email, (2) SMS, (3) Push, (4) Quit");
                int notificationChoise = Convert.ToInt32(Console.ReadLine());

                NotificationFactory factory = null;

                switch (notificationChoise)
                {
                    case 1:
                        factory = new EmailNotificationFactory();
                        break;
                    case 2:
                        factory = new SmsNotificationFactory();
                        break;
                    case 3:
                        factory = new PushNotificationFactory();
                        break;
                    default:
                        return;
                }

                INotification notification = factory.CreateNotification();
                Console.WriteLine("Please, enter the message:");
                string message = Console.ReadLine();

                notification.Send(message);

            }

            Console.WriteLine("Thank you for using the Notification System");
            Console.ReadKey();
        }
    }
}
