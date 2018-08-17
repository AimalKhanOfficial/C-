using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        private Node Root = null;

        public void AddNode(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
            }
            else
            {
                Node copy = Root;
                while (copy != null)
                {
                    if (copy.RightNode == null)
                    {
                        copy.RightNode = new Node(data);
                        break;
                    }
                    else if (copy.LeftNode == null)
                    {
                        copy.LeftNode = new Node(data);
                        break;
                    }
                    else
                    {
                        if (copy.LeftNode == null)
                        {
                            copy = copy.LeftNode;
                        }
                        else
                        {
                            copy = copy.RightNode;
                        }
                    }
                }
            }
        }


        public void ShowTree()
        {
            TraverseTree(this.Root);
        }

        private void TraverseTree(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Data);

            TraverseTree(root.LeftNode);
            TraverseTree(root.RightNode);
        }
    }
}