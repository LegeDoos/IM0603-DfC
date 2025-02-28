using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Models
{
    public class RobLinkedListNode<T>
    {
        public T Current { get; set; }

        public RobLinkedListNode<T>? Next { get; set; }

        public RobLinkedListNode(T obj)
        {
            Current = obj;
            Next = null; 
        }

    }
}
