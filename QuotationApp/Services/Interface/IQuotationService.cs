using QuotationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QuotationApp.Services.Interface
{
    public interface IQuotationService
    {
        Task<List<ItemDetailViewModel>> GetItemDetails();
        Task<bool> AddQuotationDetail(QuotationDetail quotationDetail);
        Task<QuotationSummaryViewModel> GetQuotationSummary(int id);
    }
}