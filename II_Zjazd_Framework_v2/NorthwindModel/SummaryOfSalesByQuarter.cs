using System;
using System.Collections.Generic;

namespace II_Zjazd_Framework_v2.NorthwindModel
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
