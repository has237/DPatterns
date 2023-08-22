using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Adapter
{
    class EmailNotification : INotification
    {
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Sending Email notification:\nSubject: {subject}\nMessage: {message}");
        }
    }
}
