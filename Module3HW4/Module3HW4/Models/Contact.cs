namespace Module3HW4
{
    public class Contact
    {
        public Contact(string firstName, string lastName, string phNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phNumber;
        }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string PhoneNumber { get; init; }

        public override string ToString()
        {
            return $"First name: {FirstName}\nLast name: {LastName}\nPH: {PhoneNumber}";
        }
    }
}
