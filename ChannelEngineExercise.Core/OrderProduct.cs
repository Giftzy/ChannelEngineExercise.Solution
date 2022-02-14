using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineExercise.Core
{
    public class OrderProduct
    {
        public string Status { get; set; }
        public string Gtin { get; set; }
        public string Description { get; set; }
        public StockLocation StockLocation { get; set; }
        public string ChannelProductNo { get; set; }
        public string MerchantProductNo { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return Gtin;
        }
        
    }
}
