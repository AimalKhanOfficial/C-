using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherAndSubscriberUsingDelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subscriber subscriberOne = new Subscriber();
            SubscriberTwo subscriberTwo = new SubscriberTwo();

            //Attaching an Event Handler to our Custom Event
            publisher.OnPublished += subscriberOne.EventOccured;
            publisher.OnPublished += subscriberTwo.NotificationRecieved;

            publisher.DoSomething();

            Console.ReadLine();
        }
    }
}
