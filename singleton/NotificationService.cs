using app1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.singleton
{
    class NotificationService
    {
        private static NotificationService instance;

        private NotificationService() { }

        public static NotificationService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationService();
                }
                return instance;
            }
        }

        public void SendNotification(INotification notification, string subject, string message)
        {
            notification.Send(subject, message);
        }
    }

}
