namespace Library
{
    internal class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        public int MemberID
        {
            get { return memberId; }
            private set { memberId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine();
        }
    }
}
