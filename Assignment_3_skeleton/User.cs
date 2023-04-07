using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Assignment_3_skeleton
{
    [DataContract]
    public class User
    {
        // Properties to hold user ID, name, and email.
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password;

        // Constructor to initialize the user's ID, name, email and password
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

       
        public int getId()
        {
            return Id;
        }

        public string getName()
        {
            return Name;
        }

        public string getEmail()
        {
            return Email;
        }
        
        // A method to check if the password passed is correct.
        public bool isCorrectPassword(string password)
        {
            if (Password == null && password == null)
                return true;
            else if (Password == null || password == null)
                return false;
            else
                return Password.Equals(password);
        }
        
        // A method to check if the object passed is equal to this user object.
        public bool equals(Object obj)
        {
            if (!(obj is User))
                return false;

            User other = (User)obj;

            return Id == other.Id && Name.Equals(other.Name) && Email.Equals(other.Email);
        }
    }
}
