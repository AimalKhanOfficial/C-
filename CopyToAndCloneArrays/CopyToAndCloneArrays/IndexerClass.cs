using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyToAndCloneArrays
{
    public class IndexerClass
    {
        private string[] jan2018Stds = new string[10];


        public string this[int i]
        {
            get { return jan2018Stds[i]; }
            set { jan2018Stds[i] = value; }
        }
    }
}
