using System;

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

            // Run the provided test cases
            Console.WriteLine("\nRunning Test Cases:");
            LinkedListTest(userList);
            SerializationTests(userList);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void LinkedListTest(LinkedListADT userList)
        {
            // Add your linked list tests here
        }

        static void SerializationTests(LinkedListADT userList)
        {
            // Add your serialization tests here
        }
    }
}
