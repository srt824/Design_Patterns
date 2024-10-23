using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Factories
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
