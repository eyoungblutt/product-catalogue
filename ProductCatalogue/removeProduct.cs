using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class removeProduct
    {

        //example of what to do to remove product
        public static void removeProductStatement()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            int indexToRemove = 1;

            list.RemoveAt(indexToRemove);

            Console.WriteLine(String.Join(", ", list));        // 1, 3, 4, 5
        }
    }
}
    
