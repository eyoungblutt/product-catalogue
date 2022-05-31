using System;
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

        public Product(double price)
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
