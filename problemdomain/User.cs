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

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (FirstName != null ? FirstName.GetHashCode() : 0);
                hash = hash * 23 + (LastName != null ? LastName.GetHashCode() : 0);
                return hash;
            }
        }

        // Consider adding other methods or properties if needed
    }
}
