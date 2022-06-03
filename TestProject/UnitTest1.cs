using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductCatalogue;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void testingSerialisation()
        {

            Catalogue<Book> newCatalogue = new Catalogue<Book>();
            Book newBook = new Book("New Book", "Joe", 55, "its a good book", 5);
            newCatalogue.addProduct(newBook);
            string json = JsonSerializer.Serialize(newCatalogue.list);
            var testCatalogue = JsonSerializer.Deserialize<List<Book>>(json);
            Assert.AreEqual(newCatalogue.list.First().Title, testCatalogue.First().Title);

        }

        [TestMethod]
        public void testingSerialisationBook()
        {

            Book newBook = new Book("New Book", "Joe", 55, "its a good book", 5);
            string json = JsonSerializer.Serialize(newBook);
            Book result = JsonSerializer.Deserialize<Book>(json);
            Assert.AreEqual(newBook.Title, result.Title);


        }

    }
}
