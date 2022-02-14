using ChannelEngineExercise.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineExercise.Shared.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> FetchAllOrdersByStatus(string statusType);
    }
}
