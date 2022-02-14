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
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger, IOrderService orderService, IProductService productService)
        {
            this._orderService = orderService;
            this._productService = productService;
            this._logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                //Get IN_PROGRESS status type from enum helper
                string statusType = Enum.GetName(typeof(OrderStatus), OrderStatus.IN_PROGRESS);

                //Fetch all orders
                var orderData = await _orderService.FetchAllOrdersByStatus(statusType);
                if(orderData != null && orderData.Count > 0)
                {
                    //Get Top 5 product order by quantity sold
                    var productLst = await _productService.GetTopNProductByQuantity(orderData, 5);
                    return View(new ProductViewModel
                    {
                        Products = productLst
                    });
                }
                else
                {
                    return View();
                }                
            }
            catch(Exception ex)
            { 
                _logger.LogError(ex.Message);
                return View();
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdateProductStock([FromBody] StockModel stockModel)
        {
            try
            {
                var updateResp = await _productService.UpdateProductStock(new Shared.ProductStockModel
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

                _logger.LogError(ex.Message);
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
