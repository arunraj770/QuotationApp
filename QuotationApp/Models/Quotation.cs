using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuotationApp.Models
{
    public class Quotation
    {
        public int QuotationId { get; set; }

        public DateTime QuotationDate { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}