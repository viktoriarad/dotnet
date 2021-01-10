using System;
using StoreProject.Controllers;
using StoreProject.Models;
using Moq;
using Xunit;
using System.Linq;

namespace StoreProject.Tests
{
    public class ProductControllerTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CanFilterProductsById(int idValue)
        {
            // Arrange
            Mock<IProductRepository> productRepositoryMock = new Mock<IProductRepository>();
            productRepositoryMock.Setup(x => x.Products).Returns(new ProductModel[] {
                new ProductModel {Id = 1, Name = "DummyName1"},
                new ProductModel {Id = 2, Name = "DummyName2"},
                new ProductModel {Id = 3, Name = "DummyName3"},
            }.AsQueryable<ProductModel>());

            ProductController controller = new ProductController(productRepositoryMock.Object);

            // Act
            var result = controller.GetById(idValue);
            ProductModel product = result.ViewData.Model as ProductModel;

            // Assert
            Assert.Equal(idValue, product.Id);
        }

        [Theory]
        [InlineData(99999)]
        public void ThrowsExceptionOnInvalidId(int idValue)
        {
            // Arrange
            Mock<IProductRepository> productRepositoryMock = new Mock<IProductRepository>();
            productRepositoryMock.Setup(x => x.Products).Returns(new ProductModel[] {
                new ProductModel {Id = 1, Name = "DummyName"},
                new ProductModel {Id = 2, Name = "DummyName"},
                new ProductModel {Id = 3, Name = "DummyName"},
            }.AsQueryable<ProductModel>());

            ProductController controller = new ProductController(productRepositoryMock.Object);

            // Assert
            Assert.Throws<InvalidOperationException>(() => controller.GetById(idValue));
        }

        [Fact]
        public void CanFilterProductsByCategory()
        {

            // Arrange
            // - create the mock repository
            Mock<IProductRepository> productRepositoryMock = new Mock<IProductRepository>();
            productRepositoryMock.Setup(x => x.Products).Returns(new ProductModel[] {
                new ProductModel {Id = 1, Name = "DummyName1", Category = "DummyCategory1"},
                new ProductModel {Id = 2, Name = "DummyName2", Category = "DummyCategory2"},
                new ProductModel {Id = 3, Name = "DummyName3", Category = "DummyCategory3"},
            }.AsQueryable<ProductModel>());

            ProductController controller = new ProductController(productRepositoryMock.Object);

            // Act
            ProductModel[] result =
                (controller.List("DummyCategory1").ViewData.Model as IQueryable<ProductModel>)
                    .ToArray();

            // Assert
            Assert.Single(result);
            Assert.True(result[0].Name == "DummyName1" && result[0].Category == "DummyCategory1");
        }

        [Fact]
        public void CanGetAllProducts()
        {

            // Arrange
            // - create the mock repository
            Mock<IProductRepository> productRepositoryMock = new Mock<IProductRepository>();
            ProductModel[] productModelMock = new ProductModel[] {
                new ProductModel {Id = 1, Name = "DummyName1"},
                new ProductModel {Id = 2, Name = "DummyName2"},
                new ProductModel {Id = 3, Name = "DummyName3"},
            };
            productRepositoryMock.Setup(x => x.Products).Returns(productModelMock.AsQueryable<ProductModel>());

            ProductController controller = new ProductController(productRepositoryMock.Object);

            // Act
            ProductModel[] result = (controller.GetList().ViewData.Model as IQueryable<ProductModel>).ToArray();

            // Assert
            Assert.True(result.Length == productModelMock.Length);
        }

        [Fact]
        public void RepositoryPropertyCalledOnce()
        {

            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(x => x.Products).Returns(new ProductModel[] {
                new ProductModel {Id = 1, Name = "DummyName1"},
                new ProductModel {Id = 2, Name = "DummyName2"},
                new ProductModel {Id = 3, Name = "DummyName3"},
            }.AsQueryable<ProductModel>());

            ProductController controller = new ProductController(mock.Object);

            // Act
            var result = controller.GetList();

            // Assert
            mock.VerifyGet(m => m.Products, Times.Once);
        }
    }
}
