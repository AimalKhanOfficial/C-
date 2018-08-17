using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.AddNode(1);
            tree.AddNode(2);
            tree.AddNode(3);
            tree.AddNode(4);
            tree.ShowTree();
            Console.ReadLine();
        }
    }
}
