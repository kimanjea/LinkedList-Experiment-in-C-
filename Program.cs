using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace LinkedList {

    class Program {
        static void Main(string [] args) {

        LinkedListOps azharList = new LinkedListOps(); // new creates a new instance of class linkedlist
        azharList.InsertAtTop(555); //we insert using this method
        azharList.InsertAtTop(444);
        azharList.InsertAtTop(222);
        azharList.InsertAtTop(777);
        azharList.InsertAtTop(888);
        azharList.InsertAtTop(111);
        Console.WriteLine("This is after we have inserted random values to our linkedlist");
        azharList.PrintLinkedList(); // we call this function whenever we want to print from our linkedlist current state


        Console.WriteLine();
        Console.WriteLine("We delete from the top of our List");
        azharList.DeleteAtTop();
        azharList.PrintLinkedList();

        Console.WriteLine();
        Console.WriteLine("we insert 12344 at the middle of our list where there is 222");
        azharList.InsertAtMiddle(222, 12344);
        azharList.PrintLinkedList();

        Console.WriteLine();
        Console.WriteLine("we delete 222 from our linkedlist");
        azharList.DeleteFromMiddle(222);
        azharList.PrintLinkedList();

        Console.WriteLine();
        Console.WriteLine("we insert 9990 to the bottom of our linkedlist");
        azharList.InsertATBottom(9990);
        azharList.PrintLinkedList();

        Console.WriteLine();
        Console.WriteLine("We delete from the bottom of our linkedlist");
        azharList.DeleteAtBottom();
        azharList.PrintLinkedList();

        }
    }

    class Node {
        public int data { get; set; } // this is how we get out values 
        public Node? Next {get; set;} // this is how we are able to use the reference property

        public void Display(){ // we use this to print the data in our nodes
            Console.WriteLine(data);
        }

    }

    class LinkedListOps{ // carries out linkedlist operations

        public Node? head; //we use this to access the head of the list

        public void InsertAtTop(int data){ // inserting from the top
            Node current = head; //we use current so that we dont update the head
            Node newNode = new Node(); //we cretae a new node to hold host our new data
            newNode.data=data; 

            if(current!=null) {
                newNode.Next = head;// this means that new node references head, then head can be assigned to new node
                head = newNode;//
            } else {
                newNode.Next = head; 
                head = newNode;    
            }
        }

        public void DeleteAtTop() {//deleting at the top
           Node current = head;
           Node temp = new Node(); //we create temp to hold our data when deleting from head

           temp = head.Next;
           head= temp;
                    
        }

        public void InsertAtMiddle(int data, int newdata){ //inserting frm the middle of linkedlist
            Node current = head;
            Node prev = new Node();//prev helps us access previous node 
            Node newNode = new Node();
            newNode.data = newdata;

            if(current.data != data) {
                prev = current; //we are able to access previous node by assigning prev to current
                current = current.Next;
            }

            newNode.Next = current;
            prev.Next = newNode;
            

        }

        public void DeleteFromMiddle(int data){ // deleting from the middle of linkedList
            Node current = head;
            Node prev = new Node();

            while(current.data != data){
                prev = current;
                current = current.Next;
            }

            prev.Next = current.Next;

        }

        public void InsertATBottom(int data) { //inserting from the bottom linkedlist 
            Node current = head;
            Node newNode = new Node();
            newNode.data = data;
            Node prev = new Node();


            while (current!= null){
                prev = current;
                current = current.Next;
            }

            prev.Next = newNode; 
        }

        public void DeleteAtBottom (){ //this method deletes from the bottom of the list
            Node current = head;
            Node prev = new Node();
            
            while(current.Next!= null){
                prev = current;
                current= current.Next;
            }
            prev.Next = null;
        }
        
        public void PrintLinkedList(){// we use this method to print out our new list whenever we perform on it
            Node current = head;

            while(current!= null) {
                current.Display();
                current = current.Next;
            }
            
        }
    }





}