using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgePattern.Models
{
    public class RobLinkedList<T> : iRobList<T>
    {
        private RobLinkedListNode<T>? firstNode; // todo: design to a type?

        public T? ElementAtPos(int pos)
        {
            if (firstNode == null)
            {
                throw new Exception("Not initialized");
            }
            if (Size() < pos)
            {
                throw new Exception("Out of range");
            }
            var node = firstNode;
            for (int i = 0; i < pos; i++)
            {
                node = firstNode.Next;
            }
            if (node == null)
            {
                throw new Exception("Out of range");
            }
            return node.Current;
        }

        public void Insert(int pos, T obj)
        {
            if (Size() < pos)
            {
                throw new Exception("Out of range");
            }
            if (firstNode == null)
            {
                if (pos == 0)
                {
                    // add first node
                    firstNode = new RobLinkedListNode<T>(obj); // todo: creation here? Seperate creation from use
                }
                else
                {
                    throw new Exception("Not initialized");
                }
            }
            else
            {
                var node = firstNode;
                for (int i = 0; i < pos-1; i++)
                {
                    node = firstNode.Next;
                }
                if (node != null)
                {
                    // add new node and set pointer of current
                    node.Next = new RobLinkedListNode<T>(obj) { Next = node.Next };
                }               
            }

        }

        public void Remove(int pos)
        {
            int s = Size();
            if (s <= pos)
            {
                throw new Exception("Out of range");
            }
            if (firstNode == null)
            {
                throw new Exception("Not initialized");
            }
            else
            {
                if (pos == 0)
                {
                    // delete first
                    firstNode = firstNode.Next;
                }
                else
                {
                    var node = firstNode;
                    for (int i = 0; i < pos-1; i++)
                    {
                        node = node.Next;
                    }
                    if (node != null)
                    {
                        // remove the node
                        if (node.Next != null)
                        {
                            node.Next = node.Next.Next;
                        }
                    }
                }
            }
        }

        public int Size()
        {
            int count = 0;
            if (firstNode == null)
            {
                return count;
            }
            else
            {
                var node = firstNode;
                count++;
                while (node.Next != null)
                {
                    count++;
                    node = node.Next;
                }
                return count;
            }
        }
    }
}
