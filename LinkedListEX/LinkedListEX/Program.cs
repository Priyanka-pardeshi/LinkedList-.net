using System;

namespace LinkedListEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList Llist = new LinkedList();
            Llist.Add(20);
            Llist.Add(30);
            Llist.Add(34);
            Llist.Add(2);
            Llist.Add(27);
            Llist.Add(66);
            //removed an First Elemnt
            Console.WriteLine("After added Linked list ");
            Llist.Show();
            Console.WriteLine("After removing first Node from Linked List ");
            Llist.RemoveFirstNode();
            Llist.Show();
            //Removed an last Element
            Console.WriteLine("After removing an last element of an linkedList");
            Llist.RemoveLastNode();
            Llist.Show();
            Console.ReadKey(); 
        }
    }
}
