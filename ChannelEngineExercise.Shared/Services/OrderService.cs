using ChannelEngineExercise.Core;
using ChannelEngineExercise.Shared.Interfaces;
using ChannelEngineExercise.Shared.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineExercise.Shared.Services
{
    public class OrderService : IOrderService
    {
        public static HttpClient _httpClient;

        public async Task<OrderEntity> FetchAllOrdersByStatus(string statusType)
        {
            OrderEntity allOrderEntity = new OrderEntity();
            try
            {
                using (_httpClient = new HttpClient())
                {
                    _httpClient.BaseAddress = new Uri(AppSettings.API_Url);

                    if (AppSettings.TestMode) //Testing locally
                    {
                        var file = File.ReadAllText(@"C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.Shared\Services\Data.json").ToString();
                        var readTask = JsonConvert.DeserializeObject<OrderEntity>(file);
                        if (readTask != null && readTask.Success == true && readTask.StatusCode == 200)
                        {
                            allOrderEntity = readTask;
                        }
                        else
                            allOrderEntity = null;
                    }
                    else
                    {
                        var postTask = _httpClient.GetAsync("orders?statuses="+ statusType + "&apikey=" + AppSettings.API_Key);
                        postTask.Wait();
                        var result = postTask.Result;

                        if (result.IsSuccessStatusCode)
                        {
                            var readTask = JsonConvert.DeserializeObject<OrderEntity>(await result.Content.ReadAsStringAsync());
                            if (readTask != null && readTask.Success == true && readTask.StatusCode == 200)
                            {
                                allOrderEntity = readTask;
                            }
                            else
                                allOrderEntity = null;
                        }
                        else
                            allOrderEntity = null;
                    }


                }
            }
            catch (Exception ex)
            {
                allOrderEntity = null;
            }
            return allOrderEntity;
        }

        public async Task<ProductDetail> GetTopNoProductByQuantityDescOrder(OrderEntity orderEntity, int topNo)
        {
            ProductDetail productDetail = null;
            try
            {                
                List<Lines> LineLst = new List<Lines>();
                if (orderEntity != null)
                {
                    orderEntity.Content.ForEach(x =>
                    {
                        foreach (var lineItem in x.Lines)
                        {
                            Lines xItem = new Lines
                            {
                                ChannelProductNo = lineItem.ChannelProductNo,
                                Description = lineItem.Description,
                                Gtin = lineItem.Gtin,
                                MerchantProductNo = lineItem.MerchantProductNo,
                                Quantity = lineItem.Quantity,
                                Status = lineItem.Status,
                                StockLocation = lineItem.StockLocation
                            };
                            LineLst.Add(xItem);
                        }
                    });
                }

                if (LineLst.Count > 0)
                {
                    productDetail = new ProductDetail { ProductLines = LineLst.ToList().Take(topNo).ToList() };
                }
            }
            catch(Exception ex)
            {
            }
            return productDetail;

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

                    var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(productStockModel);
                    var stringContent = new StringContent(jsonData);

                    var postTask = _httpClient.PutAsync("offer/stock?apikey=" + AppSettings.API_Key, stringContent);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = await result.Content.ReadAsStringAsync();
                        JObject jobjectData = JObject.Parse(readTask);
                        if (jobjectData.ContainsKey("StatusCode") && jobjectData.ContainsKey("Success"))
                        {
                            int jobjectStatusCode = Convert.ToInt32(jobjectData.GetValue("StatusCode"));
                            bool status = Convert.ToBoolean(jobjectData.GetValue("Success"));
                            if (jobjectStatusCode == 200 && status == true)
                            {
                                string statusMessage = Convert.ToString(jobjectData.GetValue("Message"));
                                genericAPIResponse.Message = "Request processed successfully";
                            }
                            else
                            {
                                genericAPIResponse.Status = false;
                                genericAPIResponse.Message = "Request failed";
                            }
                        }
                    }
                    else
                    {
                        genericAPIResponse.Status = false;
                        genericAPIResponse.Message = "Request failed";
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return genericAPIResponse;
        }

    }
}
