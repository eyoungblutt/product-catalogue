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
                    Console.WriteLine("You have chosen 'Create a new Catalogue' ");
                    Console.WriteLine();
                    Console.WriteLine(createNewCataloguecs.createNewCatalogueStatement());

                    break;
    
    
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

                case "4":
                    Console.WriteLine();
                    //remove a product
                    break;
                case "5":
                    Console.WriteLine();
                    //remove a catalogue
                    break;
            }

            return true;

        }
    }
}
