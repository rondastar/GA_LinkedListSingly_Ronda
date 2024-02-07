using System.ComponentModel;

namespace GA_LinkedListSingly_Ronda
{
    // Ronda Rutherford
    // GA Linked List Singly
    // 2-6-24
   
    internal class Program
    {
        static void Main(string[] args)
        {
            TestLinkedListSinglyInt();
            //TestLinkedListSinglyString();

        } // Main


        public static void TestLinkedListSinglyInt()
        {
            // Test LinkedListSingly and its methods
            LinkedListSingly<int> singly = new LinkedListSingly<int>();

            // Test InsertAtEnd
            singly.InsertAtEnd(27);


            // Test Add
            singly.Add(39);
            singly.Add(2);

            //// Test Clear
            //singly.Clear();


            //// Test RemoveAtIndex
            //singly.RemoveAtIndex(2);

            ////Test RemoveAtFront
            //singly.RemoveAtFront();
            //singly.Display();
            //singly.RemoveAtFront();
            //singly.Display();
            //singly.RemoveAtFront();
            //singly.Display();
            //singly.RemoveAtFront();
            //singly.Display();

            // Test AddAtIndex
            singly.InsertAtIndex(1, 50);
            singly.InsertAtIndex(1, 33);

            //// Test InsertAtFront
            //singly.InsertAtFront(153);

            // Test InsertAtEnd
            singly.InsertAtEnd(27);

            singly.Display();

            //// Test GetByIndex
            //Console.WriteLine($"{singly.GetByIndex(3)}");

            // Test Remove
            singly.Remove(27);

            ////Test RemoveAtEnd
            //singly.RemoveAtEnd();
            //singly.Display();

            //singly.RemoveAtEnd();
            //singly.Display();
            //singly.RemoveAtEnd();
            //singly.Display();

            //singly.RemoveAtEnd();
            //singly.Display();

            // Test Display
            singly.Display();

            // Test Count
            Console.WriteLine(singly.Count);


        } // Test LinkedListSingly


        public static void TestLinkedListSinglyString()
        {
            // Test LinkedListSingly and its methods
            LinkedListSingly<string> singlyString = new LinkedListSingly<string>();

            // Test InsertAtEnd
            singlyString.InsertAtEnd("First End");


            // Test Add
            singlyString.Add("First Add");
            singlyString.Add("Second Add");

            //// Test Clear
            //singlyString.Clear();


            //// Test RemoveAtIndex
            //singlyString.RemoveAtIndex(0);

            ////Test RemoveAtFront
            //singlyString.RemoveAtFront();
            //singlyString.Display();
            //singlyString.RemoveAtFront();
            //singlyString.Display();
            //singlyString.RemoveAtFront();
            //singlyString.Display();
            //singlyString.RemoveAtFront();
            //singlyString.Display();

            // Test AddAtIndex
            singlyString.InsertAtIndex(1, "AddAtIndex1");
            singlyString.InsertAtIndex(0, "AddAtIndex2");

            // Test InsertAtFront
            singlyString.InsertAtFront("InsertAtFront");

            // Test InsertAtEnd
            singlyString.InsertAtEnd("InsertAtEnd");

            //singlyString.Display();

            // Test GetByIndex
            Console.WriteLine($"{singlyString.GetByIndex(3)}");

            // Test Remove
            singlyString.Remove("InsertAtFront");

            ////Test RemoveAtEnd
            //singlyString.RemoveAtEnd();
            //singlyString.Display();

            //singlyString.RemoveAtEnd();
            //singlyString.Display();
            //singlyString.RemoveAtEnd();
            //singlyString.Display();

            //singlyString.RemoveAtEnd();
            //singlyString.Display();

            // Test Display
            singlyString.Display();

            // Test Count
            Console.WriteLine(singlyString.Count);


        } // Test LinkedListSingly

    } // class
} // namespace
