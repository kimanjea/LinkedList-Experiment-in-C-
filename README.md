# LinkedList Experiment in C#
# LinkedList Operations
* Description
This program demonstrates basic operations on a singly linked list. The linked list is implemented through the Node and LinkedListOps classes. The operations include inserting at the top, deleting from the top, inserting in the middle, deleting from the middle, inserting at the bottom, deleting from the bottom, and printing the current state of the linked list.

Classes
1. Node
Properties:

data: Represents the integer value stored in the node.
Next: Reference to the next node in the linked list.
Methods:

Display(): Prints the value of the node.
2. LinkedListOps
Properties:

head: Reference to the head of the linked list.
****
### Methods:
InsertAtTop(int data): Inserts a new node with the specified data at the beginning of the linked list.
DeleteAtTop(): Deletes the node at the beginning of the linked list.
InsertAtMiddle(int data, int newdata): Inserts a new node with the specified data in the middle of the linked list after the node with the given data.
DeleteFromMiddle(int data): Deletes the node from the middle of the linked list with the specified data.
InsertATBottom(int data): Inserts a new node with the specified data at the end of the linked list.
DeleteAtBottom(): Deletes the node at the end of the linked list.
PrintLinkedList(): Prints the values of all nodes in the linked list.


### Usage
Initialization:
# Create an instance of the LinkedListOps class.
LinkedListOps azharList = new LinkedListOps();

* Insert at the Top:
Use the InsertAtTop(int data) method to add nodes at the beginning of the linked list.

* Delete from the Top:
Utilize the DeleteAtTop() method to remove the node from the beginning of the linked list.

* Insert in the Middle:
Use InsertAtMiddle(int data, int newdata) to insert a new node with newdata after the node with data.

* Delete from the Middle:
Utilize DeleteFromMiddle(int data) to delete the node with the specified data from the middle of the linked list.

* Insert at the Bottom:
Use InsertATBottom(int data) to add a new node with data at the end of the linked list.

* Delete from the Bottom:
Utilize DeleteAtBottom() to remove the node at the end of the linked list.

* Print Linked List:
Use PrintLinkedList() to display the current state of the linked list.