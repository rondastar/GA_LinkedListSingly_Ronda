using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static GA_LinkedListSingly_Ronda.LinkedListSingly<T>;

namespace GA_LinkedListSingly_Ronda
{
    internal class LinkedListSingly<T>
    {
        private LinkedListNode<T> _head;
        private int count = 0;

        // Count provides access to the number of elements in the list
        public int Count { get => count; set => count = value; }

        public class LinkedListNode<T>
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
        // ============================= COMPLETE THIS!!!!!=================
        internal static void Add(T value)
        {

        } // Add

        // Removes elements by their values
        // ============================= COMPLETE THIS!!!!!=================
        internal static void Remove(T value)
        {

        } // Remove

        // Displays all elements in the linked list
        // ============================= COMPLETE THIS!!!!!=================
        internal static void Display()
        {

        } // Display

        // Implement an indexer override to access elements by index (see Core Methods)
        // ============================= COMPLETE THIS!!!!!=================

        // Inserts an element at a specified index
        // ============================= COMPLETE THIS!!!!!=================
        internal static void InsertAtIndex(int index, T value)
        {

        } // InsertAtIndex

        // Inserts an element at the beginning of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal static void InsertAtFront(T value)
        {

        } // InsertAtFront

        // Inserts an element at the end of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal static void InsertAtEnd(T value)
        {

        } // InsertAtEnd

        // Removes an element at a specified index
        // ============================= COMPLETE THIS!!!!!=================
        internal static void RemoveAtIndex(int index)
        {

        } // RemoveAtIndex

        // Removes an element at the beginning of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal static void RemoveAtFront()
        {

        } // RemoveAtFront

        // Removes an element at the end of the list
        // ============================= COMPLETE THIS!!!!!=================
        internal static void RemoveAtEnd()
        {

        } // RemoveAtEnd

        // Removes all elements from the linked list
        // ============================= COMPLETE THIS!!!!!=================
        internal static void Clear()
        {

        } // Clear

    } // class LinkedListSingly
} // namespace
