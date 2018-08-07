using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherAndSubscriberUsingDelegatesAndEvents
{
    public class Subscriber
    {
        public void EventOccured(object source, EventArgs args)
        {
            Console.WriteLine("Got a notification! Subscriber One");
        }
    }
}
