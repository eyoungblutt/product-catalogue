using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Book : Product
    {

        private string _title { get => Title; }
        private string _author { get => Author; }
        private double _pageLength { get => PageLength; }
        private string _synopsis { get => Synopsis; }

        public string Title;
        public string Author;
        public double PageLength;
        public string Synopsis;


        public Book(string title, string author, double pageLength, string synopsis, double price) : base(price)
        {
            Title = title;
            Author = author;
            PageLength = pageLength;
            Synopsis = synopsis;


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
