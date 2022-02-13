using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineExercise.Core
{
    public class RootEntity
    {
        public List<Content> Content { get; set; }
        public int Count { get; set; }
        public int TotalCount { get; set; }
        public int ItemsPerPage { get; set; }
        public int StatusCode { get; set; }
        public string LogId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}
