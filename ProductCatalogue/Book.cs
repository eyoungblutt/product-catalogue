using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class Book : Product
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
          return new Book(title, author, pageLength, synopsis, price);
        }

    }
}
