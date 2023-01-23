using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedLinkedList
{
    internal class Node
    {
        public string Data;
        public Node next;

        public Node(string data)
        {
            this.Data = data;
        }
    }
}
