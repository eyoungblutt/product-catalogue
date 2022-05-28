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
            Console.WriteLine("1 - Create Catalogue");
            Console.WriteLine("2 - View Catalugue");
            Console.WriteLine("3 - Add New Product to Catalogue");
            Console.WriteLine("4 - Remove a Product");
            Console.WriteLine("5 - Remove Catalogue");

            Console.WriteLine("Select an option number: ");


            switch (Console.ReadLine())
            {

                case "1":
                    Console.WriteLine("You have chosen option 1");
                    break;
                //put in method to be executed. create a catalogue
                case "2":
                    Console.WriteLine("You have chosen option 2");
                    Console.WriteLine("You have chosen to view your catalogue.");

                    break;
                //vie catalogue method
                case "3":
                    Console.WriteLine("You have chosen 'Add New Product to Catalogue' ");
                    Console.WriteLine();
                    Console.WriteLine(addANewProduct.addANewProductStatement());

                    break;
                // ad new product to catalogue
                case "4":
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine();
                    break;
            }

            return true;

        }
    }
}
