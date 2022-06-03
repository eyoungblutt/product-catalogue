using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public abstract class Product
    {
        private double _price;
        private string _title;

        public double Price { get => _price; set => _price = value; }
        public string Title { get => _title; set => _title = value; }

        public Product(string title, double price)
        {
            Price = price;
            Title = title;
        }

        protected Product(double price)
        {
            Price = price;
        }

        public double CalculateTax()
        {
            double markup = Price * 0.1;
            return Price + markup;
        }

    }
}
