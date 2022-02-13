using ChannelEngineExercise.Core;
using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace ChannelEngineExercise.Test
{
    
    public class ProductTest
    {
        
        private readonly IOrderService _service;
        public ProductTest()
        {
            var orderLoggerStub = new Mock<ILogger<OrderService>>();
            _service = new OrderService(orderLoggerStub.Object);
        }

        [Fact]
        public async Task GetTopNProductByQuantity_WhenCalled_ReturnsAllProducts()
        {
            //Arrange
            //Dummy Data
            var dummyInputData = new InMemoeryProductData().GetDummyTestData();
            var productList = JsonConvert.DeserializeObject<RootEntity>(dummyInputData).Content;

            // Act
            var result = await _service.GetTopNProductByQuantity(productList, 5);

            // Assert
            Assert.Equal(5, result.Count);
            Assert.IsType<List<Line>>(result);

        }

        [Fact]
        public async Task GetTopNProductByQuantity_WithNullInput_ReturnsNull()
        {
            //Arrange
            List<Content> productList = null;

            // Act
            var result = await _service.GetTopNProductByQuantity(productList, 5);

            // Assert
            Assert.Null(result);
        }
    }
}
