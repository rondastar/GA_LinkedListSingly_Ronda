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
            TestLinkedListSingly();
        } // Main
        public static void TestLinkedListSingly()
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

            //// Test AddAtIndex
            //singly.InsertAtIndex(1, 50);
            //singly.InsertAtIndex(1, 33);

            ////// Test InsertAtFront
            ////singly.InsertAtFront(153);

            //// Test InsertAtEnd
            //singly.InsertAtEnd(27);

            //singly.Display();

            //// Test GetByIndex
            //Console.WriteLine($"{singly.GetByIndex(3)}");

            //// Test Remove
            //singly.Remove(27);

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
    
    } // class
} // namespace
