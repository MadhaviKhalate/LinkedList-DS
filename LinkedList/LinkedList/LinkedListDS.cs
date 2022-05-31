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

        public void AddNode(int data)
        {
            Node node1 = new Node(data);
            if (this.head == null)
            {
                this.head = node1;
            }
            else
            {
                node1.next = this.head;
                head = node1;
            }
            Console.WriteLine("{0} inserted into LinkedList", node1.data);
        }
        public void DisplayList()
        {
            Node position = this.head;
            if (position == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (position != null)
            {
                Console.Write(position.data + " ");
                position = position.next;
            }
        }

        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node position = head;
                while (position.next != null)
                {
                    position = position.next;
                }
                position.next = node;
            }
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }

        public Node InsertNode(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node node = new Node(data);
                node.next = this.head;
                head = node;
            }
            else
            {
                while (position != 0)
                {
                    position--;
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position is exceed");
                }
            }
            return head;
        }
    }
}
   