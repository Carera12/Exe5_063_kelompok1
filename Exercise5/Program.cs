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
        

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
