using System;
using System.Collections.Generic;
using System.Text;

namespace BTS_UC2
{
    public class BinaryTree
    {
        public Node root = null;

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;//if root is null assign newNode to root
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = newNode;  //go left
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = newNode;  //go right
                            break;
                        }
                    }

                }
            }
        }

        public void TraversePreorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            TraversePreorder(root.LeftNode);

            TraversePreorder(root.RightNode);

        }

    }
}