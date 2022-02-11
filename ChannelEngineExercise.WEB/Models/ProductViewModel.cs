using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineExercise.WEB.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string GTIN { get; set; }
        public int Quantity { get; set; }
        public int StockLocationId { get; set; }
        public string MerchantProductNo { get; set; }
    }
}
