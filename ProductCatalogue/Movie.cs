using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Movie :Product 
    {

        private string _title { get => Title;  }
        private string _director { get => Director; }
        private int _runtime { get => Runtime; }
        private string _synposis { get => Synopsis; }

        public string Title;
        public string Director;
        public int Runtime;
        public string Synopsis;

        // public static void Movie( )

        public Movie(string title, string director, int runtime, string synopsis, double price) : base(price)
        {
            Title = title;
            Director = director;
            Runtime = runtime;
            Synopsis = synopsis;

            Console.WriteLine($" {title} by {director}: {synopsis}, {runtime} mins, ${price}");
        }



    }
}

