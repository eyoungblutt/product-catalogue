using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Book : Product
    {

        private string _title;
        private string _author;
        private double _pagelength;
        private string _synopsis;
        private double _price;

        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public double PageLength { get => _pagelength; set => _pagelength = value; }
        public string Synopsis { get => _synopsis; set => _synopsis = value; }
        public double Price { get => _price; set => _price = value; }


        public Book(string title, string author, double pageLength, string synopsis, double price) : base(price)
        {
            Title = title;
            Author = author;
            PageLength = pageLength;
            Synopsis = synopsis;
            Price = price;


        }
        
        public static Book createNewBook(string title, string author, double pageLength, string synopsis, double price)
        {
            if (title == null)
            {
                throw new ArgumentNullException("title unknown");
            }
            if (author == null)
            {
                throw new ArgumentNullException("author unknown");
            }
            if (pageLength == null)
            {
                throw new ArgumentNullException("pageLength unknown");
            }
            if (synopsis == null)
            {
                throw new ArgumentNullException("synopsis unknown");
            }
            if (price == null)
            {
                throw new ArgumentNullException("price unknown");
            }
            if (pageLength < 0)
            {
                throw new Exception ("page length can not be negative");
            }
            if (price < 0)
            {
                throw new Exception("price can not be negative");
            }
            return new Book(title, author, pageLength, synopsis, price);
        }

    }
}
