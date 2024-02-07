﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        // Removes elements by their values
        // ============================= COMPLETE THIS!!!!!=================
        internal void Remove(T value)
        {

        } // Remove

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

        // Implement an indexer override to access elements by index (see Core Methods)
        // ============================= COMPLETE THIS!!!!!=================

        // Inserts an element at a specified index
        // ============================= COMPLETE THIS!!!!!=================
        internal void InsertAtIndex(int index, T value)
        {
            //if (index < 0 || index >= count)
            //{
            //    throw new IndexOutOfRangeException();
            //}
        } // InsertAtIndex

        // Inserts an element at the beginning of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal void InsertAtFront(T value)
        {

        } // InsertAtFront

        // Inserts an element at the end of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal void InsertAtEnd(T value)
        {

        } // InsertAtEnd

        // Removes an element at a specified index
        // ============================= COMPLETE THIS!!!!!=================
        internal void RemoveAtIndex(int index)
        {

        } // RemoveAtIndex

        // Removes an element at the beginning of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal void RemoveAtFront()
        {

        } // RemoveAtFront

        // Removes an element at the end of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal void RemoveAtEnd()
        {

        } // RemoveAtEnd

        // Removes all elements from the linked list
        // ============================= COMPLETE THIS!!!!!=================
        internal void Clear()
        {

        } // Clear


        // ==== DELETE THIS IF NOT USED
        // Check if the specified index is within the valid range (0 to count)
        //internal static void ValidateRange(int index)
        //{
        //    // If the index is negative or the index is above our count 
        //    // throw an exception
        //    if (index < 0 || index >= count)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }
        //}

    } // class LinkedListSingly
} // namespace
