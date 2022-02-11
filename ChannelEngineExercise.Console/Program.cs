using ChannelEngineExercise.Core;
using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Services;
using ChannelEngineExercise.Shared.Utility;
using ConsoleTables;
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
            IOrderService orderService = new OrderService();

            //Get status type from enum helper
            string statusType = Enum.GetName(typeof(OrderStatus), 1);

            AppSettings.API_Url = "https://api-dev.channelengine.net/api/v2/";
            AppSettings.API_Key = "541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
            AppSettings.TestMode = true;

            var allOrders = await orderService.FetchAllOrdersByStatus(statusType);
            var topProductList = await orderService.GetTopNProductByQuantity(allOrders, 5);

            System.Console.Clear();
            ConsoleTable.From(InitListView(topProductList)).Write();

            //var product = topProductList.ProductLines.FirstOrDefault();

            //Update Product and set Stock to 25
            //await orderService.UpdateProductStock(new Shared.ProductStockModel
            //{
            //    MerchantProductNo = product.MerchantProductNo,
            //    Stock = 25,
            //    StockLocationId = product.StockLocation.Id
            //});

        }

        public static List<ProductView> InitListView(List<Line> products)
        {
            List<ProductView> productViews = new List<ProductView>();
            products.ForEach(x =>
            {
                ProductView productView = new ProductView
                {
                    GTIN = x.Gtin,
                    Quantity = x.Quantity,
                    Name = x.Description
                };

                productViews.Add(productView);
            });

            return productViews;
        }

        public class ProductView
        {
            public string Name { get; set; }
            public string GTIN { get; set; }
            public int Quantity { get; set; }
        }


    }
}
