using ChannelEngineExercise.Core;
using ChannelEngineExercise.Core.Comparers;
using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Model;
using ChannelEngineExercise.Shared.Utility;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace ChannelEngineExercise.Shared.Services
{
    public class ProductService : IProductService
    {
        private static HttpClient _httpClient;
        private readonly ILogger _logger;
        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public async Task<List<OrderProduct>> GetTopNProductByQuantity(List<Order> orderLst, int n)
        {
            List<OrderProduct> productlist = null;
            try
            {
                Requires.NotNull(orderLst, nameof(orderLst));
                var lineDict = await GetSortedProductCountGrouping(orderLst);
                productlist = lineDict.Select(t => { t.Key.Quantity = t.Value; return t.Key; }).Take(n).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                productlist = null;
            }
            return productlist;
        }

        private async Task<SortedDictionary<OrderProduct, int>> GetSortedProductCountGrouping(List<Order> orderLst)
        {
            SortedDictionary<OrderProduct, int> lineDict = new SortedDictionary<OrderProduct, int>(new LineComparer());

            foreach (var item in orderLst)
            {
                foreach (var line in item.Lines)
                {
                    if (!lineDict.ContainsKey(line))
                    {
                        lineDict.Add(line, line.Quantity);
                    }
                    else
                    {
                        lineDict[line] += line.Quantity;
                    }
                }
            }
            return await Task.FromResult(lineDict);
        }
        public async Task<GenericAPIResponse> UpdateProductStock(ProductStockModel productStockModel)
        {
            GenericAPIResponse genericAPIResponse = new GenericAPIResponse { Status = true };
            try
            {
                using (_httpClient = new HttpClient())
                {
                    //Set base api url
                    _httpClient.BaseAddress = new Uri(AppSettings.API_Url);

                    List<ProductStockModel> productStockModels = new List<ProductStockModel>()
                    {
                        productStockModel
                    };

                    var jsonData = JsonConvert.SerializeObject(productStockModels);
                    var stringContent = new StringContent(jsonData);

                    var postTask = await _httpClient.PutAsync("offer/stock?apikey=" + AppSettings.API_Key, stringContent);
                    if (postTask.IsSuccessStatusCode)
                    {
                        var readTask = await postTask.Content.ReadAsStringAsync();
                        JObject jobjectData = JObject.Parse(readTask);

                        if (jobjectData.ContainsKey("StatusCode") && jobjectData.ContainsKey("Success"))
                        {
                            int jobjectStatusCode = Convert.ToInt32(jobjectData.GetValue("StatusCode"));
                            bool status = Convert.ToBoolean(jobjectData.GetValue("Success"));
                            if (status)
                            {
                                string statusMessage = Convert.ToString(jobjectData.GetValue("Message"));
                                JObject contentInfo = JObject.Parse(jobjectData.GetValue("Content").ToString());
                                if (contentInfo != null && contentInfo.Count > 0)
                                {
                                    genericAPIResponse.Status = false;
                                    genericAPIResponse.Message = "Sorry, we could not process your request.";
                                    _logger.LogInformation("Stock location " + productStockModel.StockLocationId + " does not exist.", readTask);
                                }
                                else
                                {
                                    genericAPIResponse.Message = statusMessage;
                                }
                            }
                            else
                            {
                                _logger.LogInformation("Bad Request", readTask);
                                genericAPIResponse.Status = false;
                                genericAPIResponse.Message = "Invalid processing request";
                            }
                        }
                    }
                    else
                    {

                        _logger.LogInformation("Bad Request", postTask);
                        genericAPIResponse.Status = false;
                        genericAPIResponse.Message = "Request failed";
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                genericAPIResponse.Status = false;
                genericAPIResponse.Message = "Something went wrong while processing your request. Try again later.";
            }
            return genericAPIResponse;
        }
    }
}
