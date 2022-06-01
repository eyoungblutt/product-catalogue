using System;
using System.Collections.Generic;
using System.Text.Json;



namespace ProductCatalogue // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue<Movie> movieCatalogue = new Catalogue<Movie>();
            Catalogue<Book> bookCatalogue = new Catalogue<Book>();

            mainMenu newMenu = new mainMenu(bookCatalogue, movieCatalogue);


            Movie newMovie = new Movie("Happy", "Joe", 45, "Good movie", 9)
            {
                Title = "Happy",
                Director = "Joe",
                Runtime = 45,
                Synopsis = "Good movie",
                Price = 9,
            };

            Movie newMovie1 = new Movie("sad", "Joe", 35, "sad movie", 90);

            movieCatalogue.addProduct(newMovie);
            movieCatalogue.addProduct(newMovie1);

            //Console.WriteLine(movieCatalogue.viewCatalogue());

            //while (true)
            //{
            //    Console.WriteLine(newMenu.mainMenuOptions());
            //}

            //foreach (Movie movie in movieCatalogue.list)
            //{
            //    Console.WriteLine(movie.Title);
            //} //- this works

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "moviecatalogue.JSON");

            File.Create(filePath).Close();


            string jsonObject = JsonSerializer.Serialize<Movie>(newMovie);
            Console.WriteLine(jsonObject);
            File.WriteAllText(filePath, jsonObject);


            //Append text??

        }


    }
}