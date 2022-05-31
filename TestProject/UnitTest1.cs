using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addANewProductStatement_addNewProductCorrectly()
        {
            //Assert.AreEqual("title",ProductCatalogue.addANewProduct.addANewProductStatement("title"));
        }
       
        [TestMethod]

        public void createNewBook_textEnteredCorrectly()
        {
            Assert.AreEqual("Best Book Ever, Jon-Stewart St Paul 15 best book ever ever ever 19.95", ProductCatalogue.Book.createNewBook("Best Book Ever", "jon-stewart St Pauls", 15, "best book ever ever ever", 19.95));
        }

    }
}