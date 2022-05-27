# product-catalogue

# Project: Product Catalogue

## Due date:

03/06/22

## Objective

-   The purpose of this project is to give you hands on experience using:
    -   Testing
    -   Inheritance, Abstracts and Interfaces
    -   Generics
    -   All other topics we have covered previously
    -   JSON serialisation and File IO

## MVP

-   Create a CLI (Command Line Interface) that allows you to interact with Products inside of Catalogues
-   A Product:
    -   Is either an abstract class, or an interface
    -   Has a price property
    -   Has at least 2 derived classes, which have their own specific properties
    -   A CalculateTax method (return the price at a 10% markup)
-   A Catalogue:
    -   Has a generic type that is bound to your Product
    -   Stores a number of products in some kind of interal data structure (array, list, dictionary)
    -   A CalculateTotal method that adds together the CalculateTax of all the contained products
-   Your main loop should have a menu that the user can interact with via key presses or entering commands
-   The menu should have:
    -   Create Catalogue (optional)
    -   View a catalogue
    -   Add a new product to a catalogue
    -   Remove a product
    -   Remove a catalogue
-   Your application should save its state to a file (json recommended, up to you) every time you make an alteration to a product/catalogue
-   Product and Catalogue should have appropriate Unit tests
-   As should any other class that does not interact with the user or the file system

## Bonuses

-   Have fun

## Tips

-   Write out your classes and properties
-   As well as relationships
-   Create a flow chart for your user interaction
