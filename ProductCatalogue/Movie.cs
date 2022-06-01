using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Movie : Product
    {

        private string _title { get => Title; }
        private string _director { get => Director; }
        private double _runtime { get => Runtime; }
        private string _synposis { get => Synopsis; }

        public string Title;
        public string Director;
        public double Runtime;
        public string Synopsis;

        public Movie(string title, string director, double runtime, string synopsis, double price) : base(price)
        {
            Title = title;
            Director = director;
           Runtime = runtime;
          Synopsis = synopsis;

        }

        public static Movie createNewMovie(string title, string director, double runtime, string synopsis, double price)
        {
            if (title == null)
            {
                throw new ArgumentNullException("title unknown");
            }
            if (director == null)
            {
                throw new ArgumentNullException("author unknown");
            }
            if (runtime == 0)
            {
                throw new ArgumentNullException("pageLength unknown");
            }
            if (synopsis == null)
            {
                throw new ArgumentNullException("synopsis unknown");
            }
            if (price == 0)
            {
                throw new ArgumentNullException("price unknown");
            }
            if (runtime < 0)
            {
                throw new Exception("runtime can not be negative");
            }
            if (price < 0)
            {
                throw new Exception("price can not be negative");
            }
            return new Movie(title, director, runtime, synopsis, price);
        }
    }
}

