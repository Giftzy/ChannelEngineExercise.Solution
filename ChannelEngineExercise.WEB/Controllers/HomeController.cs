using ChannelEngineExercise.Core;
using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Utility;
using ChannelEngineExercise.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineExercise.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService orderService;
        public HomeController(IOrderService _orderService)
        {
            orderService = _orderService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                //Get status type from enum helper
                string statusType = Enum.GetName(typeof(OrderStatus), 1);

                //Fetch all orders
                var orderData = await orderService.FetchAllOrdersByStatus(statusType);

                //Get Top 5 product order by quantity sold
                var productLst = await orderService.GetTopNoProductByQuantityDescOrder(orderData, 5);

                return View(InitRequestData(productLst));
            }
            catch(Exception ex)
            {
                return View(new List<ProductViewModel>());
            }
        }

        public List<ProductViewModel> InitRequestData(ProductDetail productDetail)
        {
            List<ProductViewModel> productViews = new List<ProductViewModel>();
            productDetail.ProductLines.ForEach(x =>
            {
                ProductViewModel productViewModel = new ProductViewModel
                {
                    GTIN = x.Gtin,
                    MerchantProductNo = x.MerchantProductNo,
                    ProductName = x.Description,
                    Quantity = x.Quantity,
                    StockLocationId = x.StockLocation.Id
                };

                productViews.Add(productViewModel);
            });

            return productViews;
        }

        [HttpPost]
        public async Task<JsonResult> UpdateProductStockAsync([FromBody] StockModel stockModel)
        {
            try
            {
                var updateResp = await orderService.UpdateProductStock(new Shared.ProductStockModel
                {
                    MerchantProductNo = stockModel.MerchantProductNo,
                    Stock = stockModel.Stock,
                    StockLocationId = stockModel.StockLocationId
                });
                return Json(new
                {
                    success = updateResp.Status,
                    message = updateResp.Message
                });
            }
            catch(Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = "Something went wrong, try again later."
                });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        
    }
}
