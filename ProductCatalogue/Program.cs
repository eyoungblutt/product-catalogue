using System;
using System.Collections.Generic;
using System.Text.Json;



namespace ProductCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue<Movie> movieCatalogue = new Catalogue<Movie>();
            Catalogue<Book> bookCatalogue = new Catalogue<Book>();

            mainMenu newMenu = new mainMenu(bookCatalogue, movieCatalogue);

            while (true)
            {
                newMenu.mainMenuOptions();
            }

        }


    }
}