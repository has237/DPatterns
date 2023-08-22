using app1.Adapter;
using app1.Facade;
using app1.Factory;
using app1.Observer;
using app1.Strategy;
using System;
using System.Collections.Generic;

namespace app1
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.Write("Select a channel type (Email/SMS): ");
            string channel = Console.ReadLine();

            Console.Write("Enter subject: ");
            string subject = Console.ReadLine();

            Console.Write("Enter message: ");
            string message = Console.ReadLine();

            INotificationStrategy strategy;
            

            if (channel.ToLower() == "email")
            {
                strategy = new EmailNotificationStrategy();
                
            }
            else if (channel.ToLower() == "sms")
            {
                strategy = new SmsNotificationStrategy();
            }
            else
            {
                Console.WriteLine("Invalid channel type.");
                return;
            }
  

            //users list
            var user1 = new User("Ema");
            var user2 = new User("Liya");

            Console.WriteLine("\n");
            user1.ReceiveNotification(subject, message);
            Console.WriteLine("\n");
            user2.ReceiveNotification(subject, message);


        }
    }
}
