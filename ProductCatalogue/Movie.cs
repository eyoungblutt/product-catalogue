using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Movie : Product
    {

        private string _title;
        private string _director;
        private double _runtime;
        private string _synopsis;
        private double _price;

        public string Title { get => _title; set => _title = value; }
        public string Director { get => _director; set => _director = value; }
        public double Runtime { get => _runtime; set => _runtime = value; }
        public string Synopsis { get => _synopsis; set => _synopsis = value; }
        public double Price { get => _price; set => _price = value; }   

        public Movie(string title, string director, double runtime, string synopsis, double price) : base(price)
        {
            Title = title;
            Director = director;
            Runtime = runtime;
            Synopsis = synopsis;
            Price = price;

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

