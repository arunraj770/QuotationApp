using QuotationApp.Data.Repository.Implementation;
using QuotationApp.Data.Repository.Interface;
using QuotationApp.Services.Implementation;
using QuotationApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace QuotationApp.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IQuotationRepository, QuotationRepository>();
            container.RegisterType<IQuotationService, QuotationService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}