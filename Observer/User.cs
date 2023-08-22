using app1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Observer
{
    class User : IUser
    {
        private List<INotification> subscriptions = new List<INotification>();

        public string Name { get; private set; }

        public User(string name)
        {
            Name = name;
        }

        public void Subscribe(INotification notification)
        {
            subscriptions.Add(notification);
        }

        

        public void ReceiveNotification( string subject, string message)
        {
            Console.WriteLine($"User {Name} received  notification:\nSubject: {subject}\nMessage: {message}");
        }
    }
}
