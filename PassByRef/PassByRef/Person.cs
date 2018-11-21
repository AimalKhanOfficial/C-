using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    public class Person
    {
        public delegate void ShowDataDeletegate();
        public event ShowDataDeletegate MyEvent;

        public String FirstName { get; set; }

        public void ShowData(ShowDataDeletegate s)
        {
            s();
        }

        public void ShowFirstName()
        {
            Console.WriteLine(this.FirstName);
            ImDoneBro();
        }

        public void ImDoneBro()
        {
            MyEvent?.Invoke();
        }
    }
}
