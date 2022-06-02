using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;



namespace ProductCatalogue
{
    internal class mainMenu
    {
        public Catalogue<Book> bookCatalogue;
        public Catalogue<Movie> movieCatalogue;

        public mainMenu(Catalogue<Book> BookCatalogue, Catalogue<Movie> MovieCatalogue)
        {
            bookCatalogue = BookCatalogue;
            movieCatalogue = MovieCatalogue;

        }


        public void mainMenuOptions()
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1 - Add New Product to Catalogue");
            Console.WriteLine("2 - View Catalugue");
            Console.WriteLine("3 - Remove a Product");
            Console.WriteLine("4 - Remove Catalogue");

            Console.WriteLine("Select an option number: ");


            switch (Console.ReadLine())
            {

                case "1":
                    Console.WriteLine("You have chosen 'Add New Product to Catalogue' ");
                    Console.WriteLine();
                    addANewProduct.addANewProductStatement(bookCatalogue, movieCatalogue);
                    break;

                case "2":
                    Console.WriteLine("You have chosen to 'View your Catalogue.'");
                    Console.WriteLine();
                    Console.WriteLine("1 - View Book Catalogue");
                    Console.WriteLine("2 - View Movie Catalugue");

                    if (Console.ReadLine() == "1")
                    {
                        string bookData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "bookCatalogue.JSON"));
                        Catalogue<Book> bookCatalogue = JsonSerializer.Deserialize<Catalogue<Book>>(bookData);
                        bookCatalogue.viewCatalogue(bookCatalogue.list);

                        break;

                    }
                    else 
                    {
                        string movieData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "movieCatalogue.JSON"));
                        Catalogue<Movie> movieCatalogue = JsonSerializer.Deserialize<Catalogue<Movie>>(movieData);
                        movieCatalogue.viewCatalogue(movieCatalogue.list);
                    }
                    break;

                case "3":
                    Console.WriteLine("You have chosen to 'Remove a Product'");
                    Console.WriteLine("Where would you like to remove a product from?");
                    Console.WriteLine("1 - Remove from Book Catalogue");
                    Console.WriteLine("2 - Remove from Movie Catalugue");
                    if (Console.ReadLine() == "1")
                    {
                        string bookData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "bookCatalogue.JSON"));
                         Catalogue<Book> bookCatalogue = JsonSerializer.Deserialize<Catalogue<Book>>(bookData);
                        bookCatalogue.viewCatalogue(bookCatalogue.list);

                        Console.WriteLine("What number do you want to remove - starting from zero?");
                        int number = Int32.Parse(Console.ReadLine());

                        bookCatalogue.removeProduct(number);
                        string filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "bookcatalogue.JSON");
                        File.WriteAllText(filePath2, JsonSerializer.Serialize(bookCatalogue.list));
                        Console.WriteLine("Your new list is:");
                        bookCatalogue.viewCatalogue(bookCatalogue.list);
                        break;
                    }

                    else
                    {

                        string movieData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "movieCatalogue.JSON"));
                        Catalogue<Movie> movieCatalogue = JsonSerializer.Deserialize<Catalogue<Movie>>(movieData);
                        Console.WriteLine("What number do you want to remove - starting from zero?");
                        int number1 = Int32.Parse(Console.ReadLine());
                        movieCatalogue.removeProduct(number1);
                        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "moviecatalogue.JSON");
                        File.WriteAllText(filePath, JsonSerializer.Serialize(movieCatalogue.list));
                        Console.WriteLine("Your new list is:");
                        movieCatalogue.viewCatalogue(movieCatalogue.list);

                    }
                    break;


                case "4":
                    Console.WriteLine("You have chosen to 'Clear a Catalogue'");
                    Console.WriteLine("What catalogue would you like to clear?");
                    Console.WriteLine("1 - Clear Book Catalogue");
                    Console.WriteLine("2 - Clear Movie Catalugue");
                    
                    if(Console.ReadLine() == "1")
                    {
                        string bookData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "bookCatalogue.JSON"));
                        Catalogue<Book> bookCatalogue = JsonSerializer.Deserialize<Catalogue<Book>>(bookData);
                        bookCatalogue.clearCatalogue();
                        string filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "bookcatalogue.JSON");
                        File.WriteAllText(filePath2, JsonSerializer.Serialize(bookCatalogue.list));
                        Console.WriteLine("Your catalogue has been cleared");
                    }
                    else
                    {
                        string movieData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "movieCatalogue.JSON"));
                        Catalogue<Movie> movieCatalogue = JsonSerializer.Deserialize<Catalogue<Movie>>(movieData);
                        movieCatalogue.clearCatalogue();
                        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "moviecatalogue.JSON");
                        File.WriteAllText(filePath, JsonSerializer.Serialize(movieCatalogue.list));
                        Console.WriteLine("Your catalogue has been cleared");
                    }

                    break;

            }
           
        }

    }
}



