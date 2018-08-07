using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherAndSubscriberUsingDelegatesAndEvents
{

    //We need to do this in three steps
    //1 - Creating a Delegate 
    //2 - Defining an Event - based on that event
    //3 - Calling/Triggering the event 

    public class Publisher
    {
        //Delegate
        public delegate void PublisherEventHandler(object source, EventArgs args);

        //Event based on the delegate
        public event PublisherEventHandler OnPublished;

        public void DoSomething()
        {
            Console.WriteLine("Doing Something...");

            //Raising the event
            NotifySubscribers();
        }

        private void NotifySubscribers()
        {
            OnPublished?.Invoke(this, EventArgs.Empty);
        }
    }
}
