using System;
using System.Collections.Generic;
using System.Text;

namespace TmsTcAPI.BLL.Models
{
    class ChartDataModel
    {
    }

    public class DataItem
    {
        public dynamic Name { get; set; }
        public dynamic Value { get; set; }
        public dynamic? Extra { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public string? Label { get; set; }
    }

    public class ChartExtra
    {
        public string Code { get; set; }
    }

    public class ChartSeries
    {
        public string Name { get; set; }
        public List<DataItem> Series { get; set; }
    }
}
