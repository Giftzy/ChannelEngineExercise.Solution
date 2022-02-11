using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineExercise.WEB.Models
{
    public class StockModel
    {
        public string MerchantProductNo { get; set; }
        public int Stock { get; set; }
        public int StockLocationId { get; set; }
    }
}
