using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureStackAndQueue
{
    public class LinkedListQueue
    {
        Node head = null;

        /// <summary>
        /// UC 3 Ability to create a Queue of 56->30->70
        /// </summary>
        /// <param name="data"></param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Queue", node.data);
        }

        /// <summary>
        /// Display method to print Queue
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
