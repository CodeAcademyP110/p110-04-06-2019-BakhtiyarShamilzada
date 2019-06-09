using System.Collections.Generic;

namespace _04_June_2019
{
    public static class Market
    {
        private readonly static List<Product> _products;
        private readonly static List<Category> _categories;
        //private readonly static List<string> _letters;

        static Market()
        {
            _categories = new List<Category>
            {
                new Category {Name = "Sweets"},
                new Category {Name = "Ice Cream"},
                new Category {Name = "Fruit"}
            };
            //_letters = new List<string>
            //{
            //    "a1",
            //    "b2",
            //    "c2"
            //};
            _products = new List<Product>
            {
                new Product {Name = "Bueno", CategoryId = "0002", Count = 1, HasDiscount = false, Price = 1.5F},
                new Product {Name = "Pop Kek", CategoryId = "0001", Count = 2, HasDiscount = true, Price = 0.6F, DiscountPercent = 50F},
                new Product {Name = "Banane", CategoryId = "0003", Count = 5, HasDiscount = false, Price = 2.5F}
            };
        }
        public static List<Product> GetProducts() => _products;
        public static List<Category> GetCategories() => _categories;
        //public static List<string> GetLetters() => _letters;
        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Category GetCategoryById(string id)
        {
            for (int i = 0; i < _categories.Count; i++)
            {
                if(_categories[i].Id == id)
                {
                    return _categories[i];
                }
            }

            return null;
        }
        public static Product GetProductById(string id)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == id)
                {
                    return _products[i];
                }
            }

            return null;
        }
        public static bool DeleteCategoryById(string id)
        {
            for (int i = 0; i < _categories.Count; i++)
            {
                if(_categories[i].Id == id)
                {
                    _categories.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public static bool DeleteProductById(string id)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Id == id)
                {
                    _products.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
