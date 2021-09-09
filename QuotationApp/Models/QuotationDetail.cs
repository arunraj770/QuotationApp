using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuotationApp.Models
{
    public class QuotationDetail
    {
        [Key]
        public int Id { get; set; }
        public int QuotationId { get; set; }

        public int Detail1 { get; set; }
        public int Detail2 { get; set; }
    }
}