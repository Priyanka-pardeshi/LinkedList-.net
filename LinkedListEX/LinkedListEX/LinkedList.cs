using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListEX
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data= data;
            this.next =null;
        }
    }
    class LinkedList
    {
        public Node head;
        
        public LinkedList()
        {
            this.head = null;
        }
        
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                
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
        }

        //public Node size()
        //{
        //    Node temp;
        //    int count = 0;
        //    while (temp.next!=null)
        //    {
        //        count++;
        //    }
        //    return count;
        //}
        //public void Add(int val, int pos)
        //{
        //    Node temp, temp_node;
        //    temp_node = head;
        //    int length=size();
        //    Node node = new Node(data);
        //    if (pos < 0 || pos >= length)
        //    {
        //        Console.WriteLine("Out of range"); ;
        //    }
        //    if (pos == 0)
        //    {
        //        head = node;
        //        return;
        //    }
        //    for (int i = 0; i < length; i++)
        //    {
        //        temp = temp_node.next;
        //        temp_node.next = node;
        //        temp_node.next.next = temp;
        //    }
        //}

        ///<summary>
        ///// Show method to shoe linked list
        ///// </summary>
        public void Show()
        {
            Node temp_node;
            temp_node = head;
            while (temp_node.next!=null)
            {
                Console.WriteLine(temp_node.data+" ");
                temp_node = temp_node.next;
            }
            Console.WriteLine(temp_node.data);

        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next != null)
            {
                newNode = newNode = null;
            }
            newNode.next = null;
            return head;
        }

        public Node searchNode(int val)
        {
            while (this.head != null)
            {
                if (this.head != null)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }

        //public Node Remove(int Index)
        //{
        //    if (head == null)
        //    {
        //        return null;
        //    }
           
        //}
        //class Node<Gtype>
        //{
        //    public Gtype data;
        //    public Node<Gtype> next;
        //    public Node(Gtype data)
        //    {
        //        this.data= data;
        //        this.next = next;
        //    }
        //}

        ///// <summary>
        ///// Show method to shoe linked list
        ///// </summary>
        //public void Show()
        //{
        //    Node<Gtype> temp_node;
        //    temp_node = head;
        //    while (temp_node.next!=null)
        //    {
        //        Console.WriteLine(temp_node.data+" ");
        //        temp_node = temp_node.next;
        //    }
        //    Console.WriteLine(temp_node.data);

        //}


        //add close

        //public void Add(int val, int pos)
        //{
        //    Node<Gtype> temp, temp_node;
        //    temp_node = head;
        //    int length=size();
        //    Node<Gtype> node = new Node<Gtype>(data);
        //    if (pos < 0 || pos >= length)
        //    {
        //        Console.WriteLine("Out of range"); ;
        //    }
        //    if (pos == 0)
        //    {
        //        head = node;
        //        return;
        //    }

        //    for (int i = 0; i < length; i++)
        //    {
        //        temp = temp_node.next;
        //        temp_node.next = node;
        //        temp_node.next.next = temp;
        //    }
        //}

        //public void size()
        //{
        //    Node<Gtype> temp_node;
        //    int count = 0;
        //    while (temp_node.next != 0)
        //    {
        //        count++;
        //    }
        //}
    }
}
