using System;
using NUnit.Framework;
using NUnitLite;

namespace Assignment_3_skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the SLL class
            LinkedListADT userList = new SLL();

            // Add Users to the list
            userList.Append(new User(1, "John", "Doe", "john.doe@email.com"));
            userList.Append(new User(2, "Jane", "Doe", "jane.doe@email.com"));
            userList.Append(new User(3, "Jim", "Smith", "jim.smith@email.com"));

            // Display the list
            Console.WriteLine("List of Users:");
            for (int i = 0; i < userList.Size(); i++)
            {
                Console.WriteLine($"{i + 1}. {userList.Retrieve(i)}");
            }

            // Run the test cases
            Console.WriteLine("\nRunning Test Cases:");
            //RunTests();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine(); // Add this line
            Console.ReadKey();
        }
    }
}
