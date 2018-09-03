using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class Aimal
    {
        public delegate void CellPhone();
        public event CellPhone Call;

        public delegate string RandomDelegate(string somePara);

        public string CallSomeFunction(RandomDelegate fun)
        {
            return fun("Aimal Khan's delegate");
        }

        public String ActualFunctionImplementation(string somePara)
        {
            return somePara;
        }

        public void CallAsfand()
        {
            Console.WriteLine("Calling Asfand...");
            OnStartCall();
        }

        public void OnStartCall()
        {
            Call?.Invoke();
        }
    }
}
