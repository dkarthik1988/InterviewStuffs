using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgo
{
    public class CustomLinkList
    {
        public Node head;
        private Node current;
        public int Count;

        public CustomLinkList()
        {
            head = new Node();
            current = head;
        }

        public object this[int index]
        {
            get
            {
                return Get(index);
            }
        }

        public void AddAtLast(object data)
        {
            Node node = new Node(data);

            current.Next = node;

            current = node;
            Count++;
        }

        public void AddAtStart(object data)
        {
            Node node = new Node(data);

            current.Next = head.Next;
            head.Next = node;
            Count++;
        }

        public void RemoveFromStart()
        {
            if(Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No elements in the linked list");
            }
        }

        public void PrintAllNodes()
        {
            Node curr = head;
            while(curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine(curr.Value);
                Console.Write(" -> ");
            }
        }

        public object Get(int index)
        {
            int count = 0;
            Node curr = head;
            Node resultNode = null;

            while(curr != null)
            {
                if(count == index)
                {
                    resultNode = curr;
                    break;
                }

                count++;
                curr = curr.Next;
            }

            return resultNode.Value;
        }

        public Node Reverse(Node node)
        {
            Node prev = null;
            Node current = node;
            Node next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            node = prev;
            return node;
        }

        public bool AddAfter(Node node, string value)
        {
            Node curr = head;
            Node resultNode = null;
            int count = 0;

            //Node newNode = new Node(value);

            //newNode.Next = node.Next;

            //node.Next = newNode;

            while (curr != null)
            {
                if (curr == node)
                {
                    resultNode = curr;
                    break;
                }

                count++;
                curr = curr.Next;
            }

            return true;
        }
    }

   
    public  class Node
    {
        public object Value;
        public Node Next;

        public Node(object val)
        {
            this.Value = val;
        }

        public Node()
        {

        }
    }
}


namespace DS
{

    public class LinkList
    {
        public Node head;
        public int Count;

        public void Append(object data)
        {
            if(head == null)
            {
                head = new Node(data);
                Count++;
                return;
            }

            Node current = head;

            while(current.Next !=null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
            Count++;
        }

        public void Prepend(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            Count++;
        }

        public void DeleteWithValue(object data)
        {
            if (head == null) return;

            if(head.Data == data)
            {
                head = head.Next;
                Count--;
                return;
            }

            Node current = head;
            while(current.Next !=null)
            {
                if(current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        public void PrintReverse(Node node)
        {
            if (node.Next != null)
                PrintReverse(node.Next);

            Console.WriteLine(node.Data);

        }

        public Node Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;

            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;

            return head;
        }

        public void Reverse(Node node)
        {
            if(node.Next == null)
            {
                head = node;
                return;
            }
            Reverse(node.Next);

            Node current = node.Next;
            
            // statemetn to execute after recursive
            current.Next = node;
            node.Next = null;

        }
    }

    public class Node
    {
        public object Data;
        public Node Next;

        public Node(object data)
        {
            Data = data;
        }
    }

}