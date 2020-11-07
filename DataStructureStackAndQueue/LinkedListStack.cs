using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureStackAndQueue
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        /// <summary>
        /// UC 1 Ability to create a Stack of 56->30->70
        /// </summary>
        /// <param name="value"></param>
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} Pushed to the Stack", value);
        }

        /// <summary>
        /// Display method to print Stack
        /// </summary>
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
