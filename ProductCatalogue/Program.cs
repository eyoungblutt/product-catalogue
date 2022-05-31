using System;
using System.Collections.Generic;


namespace ProductCatalogue // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue<Movie> movieCatalogue = new Catalogue<Movie>();
            Catalogue<Book> bookCatalogue = new Catalogue<Book>();

            mainMenu newMenu = new mainMenu(bookCatalogue, movieCatalogue);


            Movie newMovie = new Movie("Happy", "Joe", 45, "Good movie", 9);
            Movie newMovie1 = new Movie("sad", "Joe", 35, "sad movie", 90);

            movieCatalogue.addProduct(newMovie);
            movieCatalogue.addProduct(newMovie1);

            //Console.WriteLine(movieCatalogue.viewCatalogue());
            
            while (true)
            {
                Console.WriteLine(newMenu.mainMenuOptions());
            }
            
            //foreach(Movie movie in movieCatalogue.list)
            //{
            //    Console.WriteLine(movie.Title);
            //}
        }


    }
}