using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Stack_Queue
{
    class LinkedListQueue
    {
        Node head = null;
     

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

            Console.WriteLine("{0} inserted into Queue,", node.data);

        }


        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty , Deletion is not possible");
                return;
            }
            Console.WriteLine("value popped is {0}", this.head.data);
            this.head = this.head.next;
        }




        internal void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }


        internal void IsEmpty()
        {
            while (this.head != null)
            {

                Dequeue();
            }
        }




    }



}

