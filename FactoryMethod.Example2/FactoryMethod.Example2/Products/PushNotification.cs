using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Products
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending push notification: {message}");
        }
    }
}
