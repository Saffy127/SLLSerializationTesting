using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Utility;
using ProblemDomain;
using System.Text.Json;

namespace SLLSerializationTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new singly linked list (SLL) of User objects
            SLL<User> userList = new SLL<User>();
            userList.Append(new User("John", "Doe"));
            userList.Append(new User("Jane", "Doe"));
            userList.Append(new User("Alice", "Smith"));

            // Serialize the SLL object
            MemoryStream memoryStream = new MemoryStream();
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            byte[] serializedData = JsonSerializer.SerializeToUtf8Bytes(userList, options);

            // Deserialize the SLL object
            MemoryStream deserializationStream = new MemoryStream(serializedData);
            SLL<User> deserializedList = JsonSerializer.Deserialize<SLL<User>>(serializedData);

            // Display the deserialized SLL object
            for (int i = 0; i < deserializedList.Size(); i++)
            {
                User user = deserializedList.Get(i);
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }
    }
}
