using System;
using StoreProject.Controllers;
using StoreProject.Models;
using Xunit;
using System.Linq;

namespace StoreProject.Tests
{
    public class ProductModelTests
    {
        [Fact]
        public void CanChangeProductName()
        {

            // Arrange
            var p = new ProductModel { Name = "DummyName", Price = 100, Description = "DummyDescription", Category = "DummyCategory" };

            // Act
            p.Name = "New DummyName";

            //Assert
            Assert.Equal("New DummyName", p.Name);
        }

        [Fact]
        public void CanChangeProductPrice()
        {

            // Arrange
            var p = new ProductModel { Name = "DummyName", Price = 100, Description = "DummyDescription", Category = "DummyCategory" };

            // Act
            p.Price = 200;

            //Assert
            Assert.Equal(200, p.Price);
        }

        [Fact]
        public void CanChangeProductDescription()
        {

            // Arrange
            var p = new ProductModel { Name = "DummyName", Price = 100, Description = "DummyDescription", Category = "DummyCategory" };

            // Act
            p.Description = "New DummyDescription";

            //Assert
            Assert.Equal("New DummyDescription", p.Description);
        }

        [Fact]
        public void CanChangeProductCategory()
        {

            // Arrange
            var p = new ProductModel { Name = "DummyName", Price = 100, Description = "DummyDescription", Category = "DummyCategory" };

            // Act
            p.Category = "New DummyCategory";

            //Assert
            Assert.Equal("New DummyCategory", p.Category);
        }
    }
}
