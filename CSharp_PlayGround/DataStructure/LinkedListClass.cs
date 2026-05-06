using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.DataStructure
{
    public class Node 
    {
        public object data;
        public Node next;
    }
    internal class LinkedListClass
    {
        public Node head = null;

        public void AddToEnd(object data) 
        {
            if (head == null) 
            {
                head = new Node();
                head.data = data;
                return;
            }

            Node current = head;

            while (current.next != null) 
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;           
        }

        public void AddToFirst(object data) 
        {
            Node newNode = new Node();
            newNode.data = data;
            if (head == null)
            {
                head = newNode;
                return;
            }
            
            newNode.next = head;
            head = newNode;
        }

        public void ReadAll() 
        {
            Node current = head;
            while (current.next != null) 
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
    public class LinkedListClassImplementation 
    {
        public static void Implement() 
        {
            LinkedListClass lnkl = new LinkedListClass();
            lnkl.AddToEnd("One");
            lnkl.AddToEnd("Two");
            lnkl.AddToEnd("3");
            lnkl.AddToEnd("4");
            lnkl.AddToFirst("First");
            lnkl.ReadAll();
        }
    }
}
