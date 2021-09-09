using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuotationApp.Models;

namespace QuotationApp.Data.Repository.Interface
{
    public interface IQuotationRepository
    {
        Task<List<ItemDetailViewModel>> GetItemDetails();
        Task<bool> AddQuotationDetail(QuotationDetail quotationDetail);
        Task<QuotationSummaryViewModel> GetQuotationSummary(int id);
    }
}
