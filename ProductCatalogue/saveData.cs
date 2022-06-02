using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProductCatalogue
{
    internal class saveData
    {

        public static string serlialise<T>(Catalogue<T> catalogue) where T : Product
        {
            return JsonSerializer.Serialize(catalogue);
        }
    }
}
