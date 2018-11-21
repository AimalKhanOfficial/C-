using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingDapper
{
    public class Employee
    {
        public int empid { get; set; }

        public string empname
        {
            get; set;
        }

        public int deptid { get; set; }

        public int salary { get; set; }
    }
}
