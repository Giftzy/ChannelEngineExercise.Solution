using ChannelEngineExercise.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineExercise.Shared.Interfaces
{
    public interface IProductService
    {

        Task<List<OrderProduct>> GetTopNProductByQuantity(List<Order> orderLst, int topNo);
        Task<GenericAPIResponse> UpdateProductStock(ProductStockModel productStockModel);
    }
}
