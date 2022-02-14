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
        
        private readonly IProductService _service;
        public ProductTest()
        {
            var loggerStub = new Mock<ILogger<ProductService>>();
            _service = new ProductService(loggerStub.Object);
        }

        [Fact]
        public async Task GetTopNProductByQuantity_WhenCalled_ReturnsAll5Products()
        {
            //Arrange
            //Dummy Data
            var dummyInputData = new InMemoeryProductData().GetDummyTestData();
            var orderList = JsonConvert.DeserializeObject<RootEntity>(dummyInputData).Content;

            // Act
            var productList = await _service.GetTopNProductByQuantity(orderList, 5);

            // Assert
            Assert.Equal(5, productList.Count);
            Assert.IsType<List<OrderProduct>>(productList);

        }

        [Fact]
        public async Task GetTopNProductByQuantity_WithNullInput_ReturnsNull()
        {
            //Arrange
            List<Order> orderList = null;

            // Act
            var productList = await _service.GetTopNProductByQuantity(orderList, 5);

            // Assert
            Assert.Null(productList);
        }
    }
}
