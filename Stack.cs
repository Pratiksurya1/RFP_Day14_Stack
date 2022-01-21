using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Test
{
    internal class Stack
    {
        public Node head;
        public void Push(int data)
        {
           
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head= node;
            }
            else
            {
                Node temp=this.head;
                while(temp.next != null)
                {
                    temp=temp.next;
                }
                node.next = temp;
                this.head = node;

            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
    }
}
