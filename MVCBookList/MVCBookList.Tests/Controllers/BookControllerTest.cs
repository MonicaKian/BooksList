
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCBookList.Controllers;

namespace MVCBookList.Tests.Controllers
{
    [TestClass]
    public class BookControllerTest
    {

        [TestMethod]
        public void ShowSearchForm()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.ShowSearchForm() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Creat()
        {
            // Arrange
            BookController controller = new BookController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
