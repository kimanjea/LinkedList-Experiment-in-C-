using System;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace LinkedList {

    class Program {
        static void Main(string [] args) {

        LinkedListOps azharList = new LinkedListOps();
        azharList.InsertAtTop(555);
        azharList.InsertAtTop(444);
        azharList.InsertAtTop(222);
        azharList.InsertAtTop(777);
        azharList.InsertAtTop(888);
        azharList.InsertAtTop(111);
        azharList.PrintLinkedList();


        Console.WriteLine();
        azharList.DeleteAtTop();
        //azharList.PrintLinkedList();

        }


    }

    class Node {
        public int data { get; set; }
        public Node? Next {get; set;}

        public void Display(){
            Console.WriteLine(data);
        }

    }

    class LinkedListOps{

        public Node? head;

        public void InsertAtTop(int data){
            Node current = head;
            Node newNode = new Node();
            newNode.data=data;

            if(current!=null) {
                newNode.Next = head;// we do the exact thing but checking for null refrences helps alot
                head = newNode;
            } else {
                newNode.Next = head; 
                head = newNode;    
            }
        }

        public void DeleteAtTop() {
            Node current = head;
            Node temp = new Node();
           
            temp.Next = head;
            head.Next = temp;
            head = temp;

            while(head!=null){
                head.Display();
                head = head.Next;
            }
            head.Display();
                    
        }
        
        public void PrintLinkedList(){
            Node current = head;

            while(current.Next!= null) {
                current.Display();
                current = current.Next;
               // current.Display();
            }
             current.Display();
            
        }
    }





}