using QuotationApp.Models;
using QuotationApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;

namespace QuotationApp.Controllers
{
    [RoutePrefix("api/QuotationApi")]
    public class QuotationApiController : ApiController
    {
        private readonly IQuotationService quotationService;

        public QuotationApiController(IQuotationService quotationService)
        {
            this.quotationService = quotationService;
        }

        [Route("GetItemDetails")]
        [HttpGet]
        public async Task<List<ItemDetailViewModel>> GetItemDetailsAsync()
        {
            var response = await quotationService.GetItemDetails();
            return response;
        }

        [Route("GetQuotationSummary/{id}")]
        [HttpGet]
        public async Task<QuotationSummaryViewModel> GetQuotationSummary(int id)
        {
            var response = await quotationService.GetQuotationSummary(id);
            return response;
        }

        [Route("AddQuotationDetail")]
        [HttpPost]
        public async Task<bool> AddQuotationDetail(QuotationDetail quotationDetail)
        {
            var response = await quotationService.AddQuotationDetail(quotationDetail);
            return response;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}