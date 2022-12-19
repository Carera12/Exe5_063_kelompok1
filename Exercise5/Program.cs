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
            public int SC;
            public Node next;
            private string sc;

            public Node(int sc)
            {
                SC = sc;
            }

            public Node(string sc)
            {
                this.sc = sc;
            }
        }
        bool empty()         
        {
            if (Silviana == null) 
                return (true); else return (false);
        }
        Node Silviana;
        Node Carera;
        public void insert(string sc)
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

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
