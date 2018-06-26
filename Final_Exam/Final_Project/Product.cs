using System;

namespace Final
{
    public class Product
    {
        private string _productId;
        private string _name;
        private double _price;

        public Product()
        {
        }

        public Product(string productId, string name, double price)
        {
            _productId = productId;
            _name = name;
            _price = price;
        }

        public string ProductName
        {
            get => _productId;
            set => _name = value;
        }

        public string ProductId
        {
            get => _productId;
            set => _productId = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }
    }
}