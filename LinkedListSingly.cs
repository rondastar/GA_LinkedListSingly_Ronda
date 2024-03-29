﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using static GA_LinkedListSingly_Ronda.LinkedListSingly<T>;

namespace GA_LinkedListSingly_Ronda
{
    internal class LinkedListSingly<T>
    {
        private LinkedListNode<T> _head;
        int count = 0;

        // Count provides access to the number of elements in the list
        public int Count { get => count; set => count = value; }

        internal class LinkedListNode<T>
        {
            // Fields         
            T _data;                    // data
            LinkedListNode<T> _next;    // .next address reference

            public LinkedListNode(T data)
            {
                _data = data;
            }

            public T Data { get => _data; set => _data = value; }
            public LinkedListNode<T> Next { get => _next; set => _next = value; }
        } // nested class LinkedListNode

        // Adds elements to the end of the linked list
        public void Add(T data)
        {
            // Create a new node to hold our data
            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            // If the list is empty, assign the new node to _head
            if(_head == null)
            {
                _head = newNode;
            }
            else
            {
                // Create a node to keep track of the current node
                LinkedListNode<T> current = _head;

                // Iterate through linked list until we are at the last link in the list
                while(current.Next != null) 
                {
                    current = current.Next;
                }

                // At the end of the list, add the new node
                current.Next = newNode;
            }

            // increment the count
            count++;
        } // Add

        // ================== This Remove works with numerical values =================
        // Removes elements by their values
        internal void Remove(T value)
        {
            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // If there is only one node in the list and its Data is the value, change the 
            // head to null, decrement the count, and return
            if (Count == 1 && Comparer<T>.Default.Compare(current.Data, value) == 0)
            {
                _head = null;

                // Decrement count
                Count--;
                return;
            }

            while (current != null)
            {
                // If the Data in the head node is the value to be removed, assign the next node to head
                if (current == _head && Comparer<T>.Default.Compare(current.Data, value) == 0)
                {
                    _head = current.Next;
                    // decrement the count
                    Count--;
                }
                // If the data in the next node is the value to be removed, assign the node after the next node
                // to be the next node
                else if (Comparer<T>.Default.Compare(current.Next.Data, value) == 0)
                {
                    current.Next = current.Next.Next;

                    // decrement the count
                    Count--;
                }

                // iterate through the list
                current = current.Next;
            }
        } // Remove


        // ================== This Remove works with non-numerical values==============
        //// Removes elements by their values
        //internal void Remove(T value)
        //{
        //    // Create a node to keep track of the current node
        //    LinkedListNode<T> current = _head;

        //    // If there is only one node in the list and its Data is the value, change the 
        //    // head to null, decrement the count, and return
        //    if (Count == 1 && Comparer<T>.Equals(current.Data, value))
        //    {
        //        _head = null;

        //        // Decrement count
        //        Count--;
        //        return;
        //    }

        //    while (current!= null)
        //    {
        //        // If the Data in the head node is the value to be removed, assign the next node to head
        //        if(current == _head && Comparer<T>.Equals(current.Data, value))
        //        {
        //            _head = current.Next;
        //            // decrement the count
        //            Count--;
        //        }
        //        // If the data in the next node is the value to be removed, assign the node after the next node
        //        // to be the next node
        //        else if(Comparer<T>.Equals(current.Data, value))
        //        {
        //            current.Next = current.Next.Next;

        //            // decrement the count
        //            Count--;
        //        }

        //        // iterate through the list
        //        current = current.Next;
        //    }

        //} // Remove

        // Displays all elements in the linked list
        internal void Display()
        {
            // Create a reference to the head
            LinkedListNode<T> current = _head;

            // while loop checks if current is not null
            while(current != null)
            {
                Console.Write(current.Data + " ");
                // set current to the next mode
                current = current.Next;
            }
            Console.WriteLine(); // Moves to next line after displaying the items in list
        } // Display

        // Indexer override to access elements by index (see Core Methods)
        public T GetByIndex(int index)
        {
            ValidateRange(index);

            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Track the current index
            int currentIndex = 0;            

            // Iterate through the list until the current index mathces the specified index
            // and return the data from the specified index
            while (current != null)
            {
                if (currentIndex == index)
                {
                    return current.Data;
                }

                currentIndex++;
                current = current.Next;
            }

            // return default
            return default(T);
        }

        // Inserts an element at a specified index
        internal void InsertAtIndex(int index, T value)
        {
            ValidateRange(index);

            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Create a new node with the input value
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            // Track the current index
            int currentIndex = 0;

            // Iterate through linked list 
            while (current != null)
            {
                // If index is 0, assign the head to be the next node and the
                // new node to be the head
                if(currentIndex == 0 && index == 0)
                {
                    newNode.Next = current;
                    _head = newNode;

                    // increment the count
                    Count++;
                    return;
                }

                // At the node before the specified index,
                // assign the  current node's next reference to the new node's Next reference.
                // Assign the new node to the current node's next reference.
                else if (currentIndex == index - 1)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;

                    // increment the count
                    Count++;
                    return;
                }

                // iterate through the linked list
                current = current.Next;

                // increment the currentIndex tracker
                currentIndex++;
            }
        } // InsertAtIndex

        // Inserts an element at the beginning of the list
        internal void InsertAtFront(T value)
        {
            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Create a new node with the input value
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            newNode.Next = current;
            _head = newNode;

            // increment the count
            Count++;
            return;
        } // InsertAtFront

        // Inserts an element at the end of the list
        internal void InsertAtEnd(T value)
        {
            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Create a new node with the input value
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            // If there is no head, assign the new node to the head and return
            if (current == null)
            {
                _head = newNode;

                // increment the count
                Count++;
                return;
            }

            // Iterate through linked list 
            while (current != null)
            {
                // At the last node, assign the new node to the current node's next reference and return
                if (current.Next == null)
                {
                    current.Next = newNode;

                    // increment the count
                    Count++;
                    return;
                }

                // iterate through the linked list
                current = current.Next;
            }
        } // InsertAtEnd

        // Removes an element at a specified index
        internal T RemoveAtIndex(int index)
        {
            ValidateRange(index);

            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Temporary placeholder for the value at the removed node
            T temp;

            // Track the current index
            int currentIndex = 0;

            // Iterate through linked list 
            while (current != null)
            {
                // If index is 0, assign the next node to be the head
                if (currentIndex == 0 && index == 0)
                {
                    temp = current.Data;
                    _head = current.Next;

                    // decrement the count
                    Count--;

                    // return the value of the removed node
                    return temp;
                }

                // At the node before the specified index, assign the data in the node at the index
                // to temp. Then change the reference for the next node to the node after the next node.
                // Return the value from the removed node
                else if (currentIndex == index - 1)
                {
                    temp = current.Next.Data;
                    current.Next = current.Next.Next;

                    // decrement the count
                    Count--;

                    // return the value of the removed node
                    return temp;
                }

                // iterate through the linked list
                current = current.Next;

                // increment the currentIndex tracker
                currentIndex++;                
            }

            // If index is not properly removed, returns default
            return default(T);
        } // RemoveAtIndex

        // Removes an element at the beginning of the list
        internal T RemoveAtFront()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no nodes in the linked list.");
                // return default if there is no node in head
                return default(T);
            }

            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Create a temporary placeholder for the value at the removed node
            T temp;

            // If the next node is not null, assign the head reference to it
            if (current.Next != null)
            {
                temp = current.Data;
                _head = current.Next;

                // decrement the count
                Count--;

                // return the value of the removed node
                return temp;
            }
            // If the next node is null, assign null to the head reference
            //else if (current != null)
            else if (current != null)
            {
                temp = current.Data;
                _head = null;

                // decrement the count
                Count--;

                // return the value of the removed node
                return temp;
            }

            // return default if there is no node in head
            return default(T);
        } // RemoveAtFront

        // Removes an element at the end of the list
        internal T RemoveAtEnd()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no nodes in the linked list.");
                // return default if there is no node in head
                return default(T);
            }

            // Create a node to keep track of the current node
            LinkedListNode<T> current = _head;

            // Create a temporary placeholder for the value at the removed node
            T temp;

            // Iterate through linked list 
            while (current != null)
            {
                // If there is only one node, store its value in temp and assign null to head.
                if (Count == 1)
                {
                    temp = current.Data;
                    _head = null;

                    // decrement the count
                    Count--;

                    // return the value of the removed node
                    return temp;
                }
                // At the second to last node, assign the data in the last node
                // to temp. Then change the reference for the next node to null.
                // Return the value from the removed node.
                else if (current.Next.Next == null)
                {
                    temp = current.Next.Data;
                    current.Next = null;

                    // increment the count
                    Count--;

                    // return the value of the removed node
                    return temp;
                }

                // iterate through the linked list
                current = current.Next;
            }

            // If there are already no nodes in the list, display message
            if (Count == 0)
            {
                Console.WriteLine("There are no nodes in the linked list.");
            }

            // If node is not properly removed, returns default
            return default(T);
        } // RemoveAtEnd

        // Removes all elements from the linked list
        internal void Clear()
        {
            _head = null;
            Count = 0;
        } // Clear

        //Check if the specified index is within the valid range(0 to count)
        internal void ValidateRange(int index)
        {
            // If the index is negative or the index is above our count 
            // throw an exception
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
        } // ValidateRange

        //// Sorts the list - example from GA assignment page
        //public void SortList()
        //{
        //    Node current, index;
        //    int temp;

        //    for (current = Head; current != null; current = current.Next)
        //    {
        //        for (index = current.Next; index != null; index = index.Next)
        //        {
        //            if (current.Data > index.Data)
        //            {
        //                temp = current.Data;
        //                current.Data = index.Data;
        //                index.Data = temp;
        //            }
        //        }
        //    }
        //}

    } // class LinkedListSingly
} // namespace
