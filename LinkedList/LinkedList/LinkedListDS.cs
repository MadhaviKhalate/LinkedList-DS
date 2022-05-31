using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListDS
    {

        public Node head;
        public void Create(int value)
        {
            Node node1 = new Node(value);
            if (this.head == null)
            {
                this.head = node1;
            }
            else
            {
                Node position = head;
                while (position.next != null)
                {
                    position = position.next;
                }
                position.next = node1;
            }
            Console.WriteLine("{0} inserted into LinkedList", node1.data);
        }
    }
}
