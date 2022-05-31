using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class addANewProduct
    {

        public static bool addANewProductStatement(Catalogue<Book> bookCatalogue, Catalogue<Movie> movieCatalogue)
        {
            Console.WriteLine("These are our product options:");
            Console.WriteLine("1 - Movie");
            Console.WriteLine("2 - Book");

            Console.WriteLine("Select an option number: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You have selected Movie");

                    Console.WriteLine("What is the title of the movie?");
                    string Title = Console.ReadLine();

                    Console.WriteLine("Who is the director?");
                    string Director = Console.ReadLine();

                    Console.WriteLine("How long does the movie go for?");
                    double Runtime = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is the synopsis?");
                    string Synopsis = Console.ReadLine();

                    Console.WriteLine("What is the price");
                    
                    double Price = Convert.ToInt32(Console.ReadLine());

                    movieCatalogue.addProduct(Movie.createNewMovie(Title, Director, Runtime, Synopsis, Price));


                    Console.WriteLine($"{Title} by {Director} : {Synopsis}, {Runtime} ${Price} has been added to your movie catalogue");

                   //Console.WriteLine(Program.());
                    break;

                case "2":
                    Console.WriteLine("You have selected Book");

                    Console.WriteLine("What is the title of the book?");
                    string title = Console.ReadLine();

                    Console.WriteLine("Who is the author?");
                    string author = Console.ReadLine();

                    Console.WriteLine("How many pages does your book have?");
                    double pageLength = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is the synopsis?");
                    string synopsis = Console.ReadLine();

                    Console.WriteLine("What is the price");
                    double price = Convert.ToInt32(Console.ReadLine());

                    Book newBook = new Book(title, author, pageLength, synopsis, price);

                    bookCatalogue.addProduct(Book.createNewBook(title, author, pageLength, synopsis, price));

                    Console.WriteLine($"{title} by {author} : {synopsis}, {pageLength} ${price} has been added to your book catalogue");

                   
                    break;

            }
            return false;
        }
    }
}
