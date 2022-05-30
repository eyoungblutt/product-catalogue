using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    internal class mainMenu
    {
        public static bool mainMenuOptions()
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
                    Console.WriteLine(addANewProduct.addANewProductStatement());
                    mainMenu.mainMenuOptions();
                    break;

                case "2":
                    Console.WriteLine("You have chosen to 'View your Catalogue.");
                    Console.WriteLine(Catalogue<Movie>.viewCatalogue());
                    mainMenu.mainMenuOptions();



                    break;
                //vie catalogue method

                case "3":
                    Console.WriteLine("You have chosen to 'Remove a Product'");
                    mainMenu.mainMenuOptions();

                    break;

                case "4":
                    Console.WriteLine("You have chosen to 'Remove a Catalogue'");
                    //remove a catalogue
                    mainMenu.mainMenuOptions();

                    break;
            }

            return true;

        }
    }
}
