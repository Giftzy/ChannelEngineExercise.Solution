using ChannelEngineExercise.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineExercise.Shared.Interfaces
{
    public interface IOrderService
    {
        Task<List<Content>> FetchAllOrdersByStatus(string statusType);
        Task<List<Line>> GetTopNProductByQuantity(List<Content> orderLst, int topNo);
        Task<GenericAPIResponse> UpdateProductStock(ProductStockModel productStockModel);
    }
}
