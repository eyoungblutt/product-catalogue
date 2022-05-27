using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal abstract class Product
    {
        private double _price { get => Price; }

        public double Price;

        public Product(double price)
        {
            Price = price;

            // could I also include title?
            // and synopsis??
        }




        //        POTENTIAL PRODUCTS FOR MY BOOK SHOP:
        //        Board games.
        //        Educational games.
        //        Journals and notebooks.
        //        Toys.
        //        Movies and albums.
        //        Maps.
        //        Bookmarks.

        public double CalculateTax()
        {
            double markup = Price * 0.1;
            return Price + markup;
        }

    }
}
