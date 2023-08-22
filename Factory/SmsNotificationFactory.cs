using app1.Adapter;
using app1.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Factory
{
    class SmsNotificationFactory : INotificationFactory
    {
        public INotificationStrategy CreateNotificationStrategy()
        {
            return new SmsNotificationStrategy();
        }
    }
}
