using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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


        public bool mainMenuOptions()
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
                    Console.WriteLine(addANewProduct.addANewProductStatement(bookCatalogue, movieCatalogue));
                    break;

                case "2":
                    Console.WriteLine("You have chosen to 'View your Catalogue.'");
                    Console.WriteLine();
                    Console.WriteLine("1 - View Book Catalogue");
                    Console.WriteLine("2 - View Movie Catalugue");

                    if (Console.ReadLine() == "1")
                    {

                        bookCatalogue.viewCatalogue(bookCatalogue.list);
                        break;

                    }
                    else 
                    {

                        movieCatalogue.viewCatalogue(movieCatalogue.list);
                    }
                    break;
                //vie catalogue method

                case "3":
                    Console.WriteLine("You have chosen to 'Remove a Product'");
                    Console.WriteLine("Where would you like to remove a product from?");
                    Console.WriteLine("1 - Remove from Book Catalogue");
                    Console.WriteLine("2 - Remove from Movie Catalugue");
                    if (Console.ReadLine() == "1")
                    {

                        bookCatalogue.viewCatalogue(bookCatalogue.list);

                        Console.WriteLine("What number do you want to remove - starting from zero?");
                        int number = Int32.Parse(Console.ReadLine());

                        bookCatalogue.removeProduct(number);
                        break;
                    }

                    else
                    {

                        movieCatalogue.viewCatalogue(movieCatalogue.list);
                        Console.WriteLine("What number do you want to remove - starting from zero?");
                        int number1 = Int32.Parse(Console.ReadLine());
                        movieCatalogue.removeProduct(number1);
                    }
                    break;


                case "4":
                    Console.WriteLine("You have chosen to 'Remove a Catalogue'");
                    //remove a catalogue
                    break;

            }
            return true;
        }

    }
}



