using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesAgain
{
    public class Publisher
    {

        public delegate void SomeDelegate(object e, EventArgs ar);

        public event SomeDelegate myEvent;

        public void DoSomething()
        {
            Console.WriteLine("I'm Done!");
            IMDone();
        }

        public virtual void IMDone()
        {
            myEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
