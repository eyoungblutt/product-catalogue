using System;

namespace ProductCatalogue // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //(string title, string author, int pageLength, string synopsis, double price) : base(price)
           // Console.WriteLine("What is the title of the book?");
           //Console.ReadLine();
           // Console.WriteLine("Who is the author?");
           // Console.ReadLine();
           // Console.WriteLine("How many pages?");
           // Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("What is the synopsis?");
           // Console.ReadLine();
           // Console.WriteLine("What is the price");
           // Convert.ToInt32(Console.ReadLine());

            //Book newBook1 = new Book( Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));


            Book newBook = new Book("Happy Book", "Erin", 65, "Its a book about Erin", 30);
            Book newBook1 = new Book("I love books", "Erin", 15, "Its about how I super love books!!", 10);


            Movie newMovie = new Movie("Great Movie", "Joe", 100, "Its a movie that is super great", 45);
            Movie newMovie1 = new Movie("I love movies, too", "Erin", 45, "Now I've made a movie about how I love movies", 25);

        }
    }
}