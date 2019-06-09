namespace _04_June_2019
{
    public class Product
    {
        private static int _id = 1;
        public Product()
        {
            Id = new string('0', 6 - _id.ToString().Length) + _id.ToString();
            _id++;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool HasDiscount { get; set; }
        private float _price;

        public float Price
        {
            get { return HasDiscount ? _price * (100 - DiscountPercent) / 100 : _price; }
            set { _price = value; }
        }

        public float DiscountPercent { get; set; }
        public float Count { get; set; }
        public string CategoryId { get; set; }

    }
}
