using ChannelEngineExercise.Core;
using ChannelEngineExercise.Core.Comparers;
using ChannelEngineExercise.Shared.Interfaces;
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
    public class OrderService : IOrderService
    {
        private static HttpClient _httpClient;
        private readonly ILogger _logger;
        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }

        public async Task<List<Order>> FetchAllOrdersByStatus(string statusType)
        {
            Requires.NotNullOrEmpty(statusType, nameof(statusType));
            List<Order> orderLst = new List<Order>();
            try
            {
                using (_httpClient = new HttpClient())
                {
                    _httpClient.BaseAddress = new Uri(AppSettings.API_Url);

                    var postTask = await _httpClient.GetAsync("orders?statuses=" + statusType + "&apikey=" + AppSettings.API_Key);
                    if (postTask.IsSuccessStatusCode)
                    {
                        var readTask = JsonConvert.DeserializeObject<RootEntity>(await postTask.Content.ReadAsStringAsync());
                        if (readTask != null && readTask.Success == true && readTask.StatusCode == 200)
                        {
                            orderLst = readTask.Content;
                        }
                        else
                        {
                            orderLst = null;
                        }
                    }
                    else
                    {

                        _logger.LogInformation("", "Bad Request");
                        orderLst = null;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                orderLst = null;
            }
            return orderLst;
        }

       

    }
}
