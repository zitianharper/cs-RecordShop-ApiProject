using Microsoft.AspNetCore.Mvc;
using Moq;
using RecordShop.Models;
using RecordShop.Services;
using Shouldly;
using System.Security.Cryptography.X509Certificates;

namespace RecordShopTests.Services
{
    public class AlbumServiceTests
    {
        private Mock<IAlbumRepository> _mockRepo;
        private AlbumService _services;


        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IAlbumRepository>();
            _services = new AlbumService(_mockRepo.Object);
        }

        [Test]
        public void ReturnOnlyAlbumsWithStock()
        {
            //Arrange

            var mockData = new List<Album>
            {
                 new Album
                {
                    Id = 1,
                    Name = "Eternal",
                    Artist = "Taemin",
                    Release = 2024,
                    Genre = "K-pop",
                    StockQuantity = 5,
                    Price = 19.99m
                },
                new Album
                {
                    Id = 2,
                    Name = "Thriller",
                    Artist = "Michael Jackson",
                    Release = 1982,
                    Genre = "Pop",
                    StockQuantity = 0,
                    Price = 17.50m
                }
            };

            _mockRepo.Setup(r => r.FindAlbumInStock()).Returns(mockData);
        

            //Act
            var result = _services.ListAlbumInStock();
            //Assert
            result.Count.ShouldBe(1);
            result[0].Name.ShouldBe("Eternal");

        }

        [Test]
        public void ReturnAlbumByIdMatchesResultId()
        {
            //Arrange

            var mockData = new Album
            {
                Id = 1,
                Name = "Eternal",
                Artist = "Taemin",
                Release = 2024,
                Genre = "K-pop",
                StockQuantity = 5,
                Price = 19.99m
            };

            _mockRepo.Setup(r => r.FindAlbumById(1)).Returns(mockData);

            //Act
            var result = _services.ListAlbumById(1);

            //Assert
            result.Id.ShouldBe(1);
        }

        [Test]
        public void PostAlbum_ReturnsAlbumWithId()
        {
            var input = new Album
            {
                Name = "New Album",
                StockQuantity = 5,
                Price = 10m
            };

            var returned = new Album
            {
                Id = 1,
                Name = "New Album",
                StockQuantity = 5,
                Price = 10m
            };

            _mockRepo
                .Setup(r => r.MakeAlbum(input))
                .Returns(returned);

            var result = _services.CreateAlbum(input);

            result.Id.ShouldBe(1);
            result.Name.ShouldBe("New Album");

        }
    }
}