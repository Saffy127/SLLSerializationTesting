namespace ProblemDomain
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            User other = (User)obj;
            return FirstName == other.FirstName && LastName == other.LastName;
        }

        // Consider overriding GetHashCode as well if needed
    }
}
