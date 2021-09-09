using QuotationApp.Data.Repository.Interface;
using QuotationApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace QuotationApp.Data.Repository.Implementation
{
    public class QuotationRepository : IQuotationRepository
    {
        private readonly ApplicationDbContext _context;
        public QuotationRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public async Task<bool> AddQuotationDetail(QuotationDetail quotationDetail)
        {
            await Task.FromResult(_context.Database.SqlQuery<QuotationDetail>("AddItemDetails @quotationId @detail1 @detail2",
                new SqlParameter("@quotationId", quotationDetail.QuotationId),
                new SqlParameter("@detail1", quotationDetail.Detail1),
                new SqlParameter("@detail2", quotationDetail.Detail2)));

            return true;
        }

        public async Task<List<ItemDetailViewModel>> GetItemDetails()
        {
            var response = await Task.FromResult(_context.ItemDetails.Select(x => new ItemDetailViewModel() { Id = x.Id, DetailName = x.DetailName }).ToList());
            return response;
        }

        public async Task<QuotationSummaryViewModel> GetQuotationSummary(int id)
        {
            var response = await Task.FromResult(_context.Quatations.Select(x => new QuotationSummaryViewModel() { QuotationId = x.QuotationId, Description = x.Description, QuotationDate = x.QuotationDate, Subject = x.Subject, Status = x.Status }).FirstOrDefault());
            return response;
        }
    }
}