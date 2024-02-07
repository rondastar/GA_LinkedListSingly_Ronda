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
            // Test LinkedListSingly and its methods
            LinkedListSingly<int> singly = new LinkedListSingly<int>();

            // Test InsertAtEnd
            singly.InsertAtEnd(27);


            // Test Add
            singly.Add(39);
            singly.Add(2);





            // Test AddAtIndex
            singly.InsertAtIndex(1, 50);
            singly.InsertAtIndex(0, 33);

            // Test InsertAtFront
            singly.InsertAtFront(153);

            // Test InsertAtEnd
            singly.InsertAtEnd(27);

            // Test Display
            singly.Display();

            // Test Count
            Console.WriteLine(singly.Count);


        }
    }
}
