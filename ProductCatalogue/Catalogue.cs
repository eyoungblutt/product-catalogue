using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Catalogue<T> where T : Product
        //this is the list within which your products will be stored. Can be more then one catalogue
    {

        private T[] _catalogueMain = new T[2];

        public T First => _catalogueMain[0];
        public T Second => _catalogueMain[1];

        public Catalogue(T first, T second)
        {
            _catalogueMain[0] = first;
            _catalogueMain[1] = second;

            //for(int i = 0; i < _catalogueMain.Length; i++)
            //{
            //    Console.WriteLine($"{0}", _catalogueMain[i]);
            //}


        }

        public override string ToString()
        {
            return $"1. {_catalogueMain[0]}; 2. {_catalogueMain[1]}";
        }


        public void newCatalogue(T item)
        {
            _catalogueMain[0] = item;
        }

        // -   A CalculateTotal method that adds together the CalculateTax of all the contained products
        //public double CalculateTax()
        //{
        //    double markup = Price * 0.1;
        //    return Price + markup;
        //}
        public double CalculateTotal(double price)
        {
            double total = 0;
            foreach (T item in _catalogueMain)
            {
                total = total + price;
                return total;
            }
            return 0;
        }

    }
}
