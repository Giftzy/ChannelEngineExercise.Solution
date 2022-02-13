using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineExercise.Core
{
    public class Content
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public int ChannelId { get; set; }
        public string GlobalChannelName { get; set; }
        public int GlobalChannelId { get; set; }
        public string ChannelOrderNo { get; set; }
        public string MerchantOrderNo { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Line> Lines { get; set; }
    }
}
