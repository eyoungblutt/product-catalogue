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
        public static List<T> list = new List<T>();

        public static void addProduct(T product)
        {
            list.Add(product);
        }

        public static void removeProduct(T product)
        {
            list.Remove(product);

        }


        public static bool viewCatalogue()
        {
            foreach (T Title in list)
            {
                 Console.WriteLine($"{Title}");
            }
            return true;
        }

        public override string ToString()
        {
            return $" ";
        }
        public double CalculateTotal(double price)
        {
            double total = 0;
            foreach (T item in list)
            {
                total += price;
                return total;
            }
            return 0;
        }

    }
}
