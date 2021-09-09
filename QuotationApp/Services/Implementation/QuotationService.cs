using QuotationApp.Data.Repository.Interface;
using QuotationApp.Models;
using QuotationApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QuotationApp.Services.Implementation
{
    public class QuotationService : IQuotationService
    {
        private readonly IQuotationRepository quotationRepository;

        public QuotationService()
        {
        }

        public QuotationService(IQuotationRepository quotationRepository)
        {
            this.quotationRepository = quotationRepository;
        }

        public async Task<bool> AddQuotationDetail(QuotationDetail quotationDetail)
        {
            return await quotationRepository.AddQuotationDetail(quotationDetail);
        }

        public async Task<List<ItemDetailViewModel>> GetItemDetails()
        {
            return await quotationRepository.GetItemDetails();
        }

        public async Task<QuotationSummaryViewModel> GetQuotationSummary(int id)
        {
            return await quotationRepository.GetQuotationSummary(id);
        }
    }
}