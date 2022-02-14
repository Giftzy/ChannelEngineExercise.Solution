using ChannelEngineExercise.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChannelEngineExercise.WEB.Models
{
    public class ProductViewModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public List<OrderProduct> Products { get; set; }
    }
}
