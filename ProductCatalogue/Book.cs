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
        private int _pageLength { get => PageLength; }
        private string _synopsis { get => Synopsis; }

        public string Title;
        public string Author;
        public int PageLength;
        public string Synopsis;


        public Book(string title, string author, int pageLength, string synopsis, double price) : base(price)
        {
            Title = title;
            Author = author;
            PageLength = pageLength;
            Synopsis = synopsis;


        }


        //public void createBook(string title, string author, int pageLength, string synopsis, double price)
        //{

        //    Console.WriteLine("What is the title of the book?");
        //    string Title = Console.ReadLine();

        //    Console.WriteLine("Who is the author?");
        //    string Author = Console.ReadLine();

        //    Console.WriteLine("How many pages does your book have?");
        //    double PageLength = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("What is the synopsis?");
        //    string Synopsis = Console.ReadLine();

        //    Console.WriteLine("What is the price");
        //    double Price = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($" {this.Title} by {this.Author}: {this.Synopsis}, {this.PageLength} pages, ${this.Price}");

        //}

    }
}
