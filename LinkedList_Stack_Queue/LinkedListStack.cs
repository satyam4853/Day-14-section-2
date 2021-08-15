using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Stack_Queue
{
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
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
            Console.WriteLine("{0} pushed to stack ", value);
        }

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
