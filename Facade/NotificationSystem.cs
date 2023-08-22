using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app1.singleton;
using app1.Factory;
using app1.Strategy;
using app1.Adapter;

namespace app1.Facade
{
    class NotificationSystem
    {
        private INotificationStrategy notificationStrategy;
        private NotificationService notificationService;
        private INotification notification;

        public NotificationSystem(INotificationStrategy strategy)
        {
            notificationStrategy = strategy;
            notificationService = NotificationService.Instance;
            
        }

        public void SendNotification(INotification notification, string subject, string message)
        {
            this.notification = notification;

            notificationService.SendNotification(notification, subject, message);
        }


        //private INotification notification;

        //public NotificationSystem(INotificationStrategy strategy)
        //{
        //    notificationStrategy = strategy;
        //    notificationService = NotificationService.Instance;

        //}



        //public void SendNotification(INotification notification , string subject, string message)
        //{
        //    this.notification = notification;
        //    //notificationStrategy.Send(channel, subject, message);
        //    notificationService.SendNotification(notification, subject, message);
        //}
    }
}



//private INotificationFactory notificationFactory;

//public NotificationSystem(INotificationFactory factory)
//{
//    notificationFactory = factory;
//}

//public void SendNotification(string channel, string subject, string message)
//{
//    var notification = notificationFactory.CreateNotification();
//    NotificationService.Instance.SendNotification(notification, subject, message);//}