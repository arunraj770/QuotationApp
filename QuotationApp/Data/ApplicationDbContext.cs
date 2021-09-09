using QuotationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuotationApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ConnectionString")
        {
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<Quotation> Quatations { get; set; }

        public DbSet<QuotationDetail> QuatationDetails { get; set; }
        public DbSet<ItemDetail> ItemDetails { get; set; }
    }
}