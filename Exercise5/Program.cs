using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class QueueLinkedList
    {
        class Node
        {
            public string SC;
            public Node next;

            public Node(string sc)
            {
                SC = sc;
            }
            
        }
        bool Empty()
        {
            if (Silviana == null)
                return (true);
            else
                return (false);
        }
        Node Silviana;
        Node Carera;
        public void Insert(string sc)
        {
            var newNode = new Node(sc);
            if (Carera != null)
            {
                Carera.next = newNode;
            }
            Carera = newNode;
            if (Silviana == null)
            {
                Silviana = newNode;
            }
        }
        public void Delete()
        {
            if (Silviana == null)
            {
                throw new InvalidProgramException("The queue is empty");
            }
            var sc = Silviana.SC;
            Silviana = Silviana.next;
            if (Silviana == null)
            {
                Silviana = null;
            }
        }
        public void Display()
        {
            Node tmp;
            if (Empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = Silviana; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.SC);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                QueueLinkedList q = new QueueLinkedList();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("\nSTACK MENU");
                    Console.WriteLine("1. insert");
                    Console.WriteLine("2. delete");
                    Console.WriteLine("3. display");
                    Console.WriteLine("4. exit");
                    Console.WriteLine("\nEnter your choice: ");
                    string input = Console.ReadLine();
                    char ch = Convert.ToChar(input == "" ? "0" : input);
                    switch(ch)
                    {
                        case '1':
                            Console.WriteLine("\nEnter your alfabeth: ");
                            string num = Convert.ToString(Console.ReadLine());
                            q.Insert(num);
                            break;
                        case '2':
                            q.Delete();
                            Console.WriteLine("item deleted");
                            break;
                        case'3':
                            q.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("\nInvalid choice");
                            break;
                    }
                }
            }
        }

       
    }
}
