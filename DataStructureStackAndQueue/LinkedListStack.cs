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

        /// <summary>
        /// UC 2 Ability to peek and pop from the Stack till it is empty 56->30->70
        /// Ability to Peek from the stack 
        /// </summary>
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }

        /// <summary>
        /// Ability to Pop from the stack
        /// </summary>
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty, deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }

        /// <summary>
        /// Ability to peek and pop from the Stack till it is empty 56->30->70
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
                Display();
            }
            Console.WriteLine("Stack is Empty");
        }
    }
}
