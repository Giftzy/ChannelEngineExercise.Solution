using ChannelEngineExercise.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineExercise.Shared.Interfaces
{
    public interface IOrderService
    {
        Task<OrderEntity> FetchAllOrdersByStatus(string statusType);
        Task<ProductDetail> GetTopNoProductByQuantityDescOrder(OrderEntity orderEntity, int topNo);
        Task<GenericAPIResponse> UpdateProductStock(ProductStockModel productStockModel);
    }
}
