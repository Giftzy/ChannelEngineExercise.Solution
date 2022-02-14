using ChannelEngineExercise.Core;
using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Services;
using ChannelEngineExercise.Shared.Utility;
using ConsoleTables;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ChannelEngineExercise.Console
{
    public class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider(); 

            IOrderService orderService = new OrderService(serviceProvider.GetRequiredService<ILogger<OrderService>>());
            IProductService productService = new ProductService(serviceProvider.GetRequiredService<ILogger<ProductService>>());
            ConfigureAppSettings();

            //Get status type from enum helper
            string statusType = Enum.GetName(typeof(OrderStatus), 1);            

            var allOrders = await orderService.FetchAllOrdersByStatus(statusType);
            var topProductList = await productService.GetTopNProductByQuantity(allOrders, 5);

            //Print list of Top N Products to Console
            System.Console.Clear();
            ConsoleTable.From(InitListView(topProductList)).Write();

            System.Console.WriteLine("Enter Product Code to update product stock to 25:");
            string prodCode = System.Console.ReadLine();
            if(!string.IsNullOrEmpty(prodCode))
            {
                var product = topProductList.Where(x => x.MerchantProductNo == prodCode).FirstOrDefault();
                //Update Product and set Stock to 25
                var updateStatus = await productService.UpdateProductStock(new Shared.ProductStockModel
                {
                    MerchantProductNo = product.MerchantProductNo,
                    Stock = 25,
                    StockLocationId = product.StockLocation.Id
                });

                System.Console.WriteLine(updateStatus.Message);
            }
            else
            {
                System.Console.WriteLine("Invalid input");
            }
           

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //we will configure logging here
            services.AddLogging(configure => configure.AddConsole())
                .AddTransient<IOrderService, OrderService>()
                .AddTransient<IProductService, ProductService>();
        }

        private static void ConfigureAppSettings()
        {
            AppSettings.API_Url = "https://api-dev.channelengine.net/api/v2/";
            AppSettings.API_Key = "541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
        }
        public static List<ProductView> InitListView(List<OrderProduct> products)
        {
            List<ProductView> productViews = new List<ProductView>();
            products.ForEach(x =>
            {
                ProductView productView = new ProductView
                {
                    GTIN = x.Gtin,
                    TotalQuantity = x.Quantity,
                    Name = x.Description,
                    ProductCode = x.MerchantProductNo
                };

                productViews.Add(productView);
            });

            return productViews;
        }

        public class ProductView
        {
            public string Name { get; set; }
            public string GTIN { get; set; }
            public int TotalQuantity { get; set; }
            public string ProductCode { get; set; }

        }


    }
}
