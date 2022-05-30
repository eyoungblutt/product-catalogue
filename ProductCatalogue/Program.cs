using System;
using System.Collections.Generic;

namespace ProductCatalogue // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue<Book> bookCatalogue = new Catalogue<Book>(); //creating a book catalogue
            Catalogue<Movie> movieCatalogue = new Catalogue<Movie>();

            //Two hardcoded catalogues for the user to use

            //connects to main menu
            Console.WriteLine(mainMenu.mainMenuOptions());

            


          

        }
    }
}