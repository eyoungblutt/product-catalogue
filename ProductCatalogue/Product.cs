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
        private double _price { get => Price; }

        public double Price;
        public string Title;

        public Product(double price, string title)
        {
            Price = price;
            Title = title;
        }

        public static ICollection CalculateTax(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
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
