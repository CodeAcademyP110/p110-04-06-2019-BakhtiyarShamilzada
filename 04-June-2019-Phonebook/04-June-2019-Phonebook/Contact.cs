namespace _04_June_2019_Phonebook
{
    public class Contact
    {
        private static int _id = 1;
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public Contact()
        {
            Id = new string('0', 4 - _id.ToString().Length) + _id.ToString();
            _id++;
        }
    }
}
