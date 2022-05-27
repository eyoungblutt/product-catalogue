using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Catalogue<T> : Product //this is the list within which your products will be stored. Can be more then one catalogue
    {

        private T[] _catalogueMain = new T[0];


        public Catalogue(double price) : base(price)
        {
        }
    }
}
