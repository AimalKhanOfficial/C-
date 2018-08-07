using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherAndSubscriberUsingDelegatesAndEvents
{
    class SubscriberTwo
    {
        public void NotificationRecieved(object source, EventArgs args)
        {
            Console.WriteLine("Got a notification! Subscriber Two");
        }
    }
}
