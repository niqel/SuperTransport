using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmsTcAPI.Models
{
    public class DistanceMatrix
    {
        public List<string> origin_addresses { get; set; }
        public List<string> destination_addresses { get; set; }
        public List<DistanceRow> rows { get; set; }
    }

    public class DistanceRow 
    {
        public List<RowElement> elements { get; set; }
    }

    public class RowElement
    {
        public ElementDistance distance { get; set; }
        public ElementDuration duration { get; set; }
    }

    public class ElementDistance : IComparable<ElementDistance>
    {
        public string text { get; set; }
        public int value { get; set; }

        public int CompareTo(ElementDistance other)
        {
            return value.CompareTo(other.value);
        }
    }

    public class ElementDuration
    {
        public string text { get; set; }
        public int value { get; set; }
    }
}