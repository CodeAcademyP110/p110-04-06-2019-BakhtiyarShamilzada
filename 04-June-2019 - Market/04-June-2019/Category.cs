namespace _04_June_2019
{
    public class Category
    {
        private static int _id = 1;
        public Category()
        {
            Id = new string('0', 4 - _id.ToString().Length) + _id.ToString();
            _id++;
        }
        public Category(string name) :this()
        {
            Name = name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
