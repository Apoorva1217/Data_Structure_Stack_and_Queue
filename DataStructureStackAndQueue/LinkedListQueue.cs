using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureStackAndQueue
{
    public class LinkedListQueue
    {
        Node head = null;
        Node tail = null;

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

        /// <summary>
        /// UC 4 Ability to dequeue from the beginning
        /// </summary>
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty, deletion is not possible");
                return;
            }
            else
            {
                Node temp = this.head;
                this.head = this.head.next;

                if (this.head == null)
                {
                    this.tail = null;
                }
                Console.WriteLine("{0} is deleted from Queue", temp.data);

            }
            Console.WriteLine("Linked List After Deletion");
        }
    }
}
