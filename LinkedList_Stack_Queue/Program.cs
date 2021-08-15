using System;

namespace LinkedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Welcome to LinedList Stack And Queue Problem-------------------");
            LinkedListStack list = new LinkedListStack();
            list.push(70);
            list.push(30);
            list.push(56);
            list.Display();
            list.peek();
            list.pop();
            list.IsEmpty();
            list.peek();





        }
    }
}
