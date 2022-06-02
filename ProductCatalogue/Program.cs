using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace ProductCatalogue // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue<Movie> movieCatalogue = new Catalogue<Movie>();
            Catalogue<Book> bookCatalogue = new Catalogue<Book>();

            mainMenu newMenu = new mainMenu(bookCatalogue, movieCatalogue);

            Book newBook = new Book("New Book", "Joe", 55, "its a good book", 5);

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

            

            //while (true)
            //{
            //    Console.WriteLine(newMenu.mainMenuOptions());
            //}


            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "moviecatalogue.JSON");
            Console.WriteLine(filePath);
            File.Create(filePath).Close();
            string jsonObject = JsonSerializer.Serialize(newMovie);
            Console.WriteLine(jsonObject);
            File.WriteAllText(filePath, jsonObject);

            string filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "bookcatalogue.JSON");
            Console.WriteLine(filePath2);
            File.Create(filePath2).Close();
            string jsonObject2 = JsonSerializer.Serialize(newBook);
            Console.WriteLine(jsonObject2);
            File.WriteAllText(filePath2, jsonObject2);

           

        }


    }
}