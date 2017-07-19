using DS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgo
{

    public class Program
    {
        static int solution(string S)
        {
            if (!string.IsNullOrEmpty(S))
            {
                int V = Convert.ToInt32(S, 2);
                int stepCount = 0;

                if (V != 0)
                {
                    bool isEnd = false;
                    while (!isEnd)
                    {
                        bool isEven = (V % 2) == 0;
                        if (isEven)
                        {
                            V = V / 2;
                        }
                        else
                        {
                            V = V - 1;
                        }

                        stepCount++;
                        if (V == 0)
                            isEnd = true;

                    }
                }

                return stepCount;
            }
            return 0;


        }

        static int solution1(string S)
        {
            string originalValue = S;
            int cyclicCount=0;

            for(int i =0; i < S.Length -1; i++)
            {
                string subStringToAppend = S.Substring(0, 1);
                string remainingString = S.Substring(1, S.Length - 1);
                S = remainingString + subStringToAppend;

                if (originalValue == S)
                {
                    break; 
                }
                cyclicCount++;
            }
            return cyclicCount;   
        }

        static void solution2(string S, string T)
        {
            string[] s = S.Split(':');
            TimeSpan ts1 = new TimeSpan(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]));


            string[] t = T.Split(':');
            TimeSpan ts2 = new TimeSpan(Convert.ToInt32(t[0]), Convert.ToInt32(t[1]), Convert.ToInt32(t[2]));


        }

        static void Main(string[] args)
        {
           solution2("15:15:00", "15:15:12");
            //solution2("22:22:21", "22:22:23");
            solution1("s codility");


            // solution("101010");

            LinkList llist = new LinkList();
            llist.Append(5);
            llist.Append(6);
            llist.Append(7);
            llist.Append(8);
            llist.Prepend(4);



            //llist.DeleteWithValue(6);

            llist.PrintReverse(llist.head);

            DS.Node reversedNode = llist.Reverse();
            //llist.Reverse(llist.head);
            Console.ReadLine();




            CustomLinkList list = new CustomLinkList();
            list.AddAtLast("test1");
            list.AddAtLast("test4");
            list.AddAtLast("test3");
            list.AddAtLast("test2");
            list.AddAtStart("test0");



            Node node = list.Reverse(list.head);

            object val = list[2];

            list.PrintAllNodes();

            list.RemoveFromStart();

            list.PrintAllNodes();


            Console.ReadLine();

            LinkedList<string> strLinkedList = new LinkedList<string>();



            List<string> str = new List<string>();
            str.Add("test1");
            str.Add("test4");
            str.Add("test3");
            str.Add("test2");

            int inde = str.IndexOf("test4");



            CustomLinkList l1 = new CustomLinkList();
            l1.head = new Node() { Value = 1 };

            Node n2 = new Node() { Value = 2 };

            Node n3 = new Node() { Value = 3 };

            l1.head.Next = n2;

            n2.Next = n3;



        }
    }


    // A complete working Java program to demonstrate all insertion methods
    // on linked list
    public class LinkedList
    {
        public Node head;  // head of list

        /* Linked list Node*/
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null; }
        }

        /* Inserts a new Node at front of the list. */
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                      Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        /* Inserts a new node after the given prev_node. */
        public void insertAfter(Node prev_node, int new_data)
        {
            /* 1. Check if the given Node is null */
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }

            /* 2 & 3: Allocate the Node &
                      Put in the data*/
            Node new_node = new Node(new_data);

            /* 4. Make next of new Node as next of prev_node */
            new_node.next = prev_node.next;

            /* 5. make next of prev_node as new_node */
            prev_node.next = new_node;
        }

        /* Appends a new node at the end.  This method is 
           defined inside LinkedList class shown above */
        public void append(int new_data)
        {
            /* 1. Allocate the Node &
               2. Put in the data
               3. Set next as null */
            Node new_node = new Node(new_data);

            /* 4. If the Linked List is empty, then make the
                  new node as head */
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            /* 4. This new node is going to be the last node, so
                  make next of it as null */
            new_node.next = null;

            /* 5. Else traverse till the last node */
            Node last = head;
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = new_node;
            return;
        }

        /* This function prints contents of linked list starting from
            the given node */
        public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.data + " ");
                tnode = tnode.next;
            }
        }

        /* Driver program to test above functions. Ideally this function
           should be in a separate user class.  It is kept here to keep
           code compact */
        public static void Mains(String[] args)
        {
            /* Start with the empty list */
            LinkedList llist = new LinkedList();

            // Insert 6.  So linked list becomes 6->NUllist
            llist.append(6);

            // Insert 7 at the beginning. So linked list becomes
            // 7->6->NUllist
            llist.push(7);

            // Insert 1 at the beginning. So linked list becomes
            // 1->7->6->NUllist
            llist.push(1);

            // Insert 4 at the end. So linked list becomes
            // 1->7->6->4->NUllist
            llist.append(4);

            // Insert 8, after 7. So linked list becomes
            // 1->7->8->6->4->NUllist
            llist.insertAfter(llist.head.next, 8);

            Console.WriteLine("\nCreated Linked list is: ");
            llist.printList();
        }
    }
}
