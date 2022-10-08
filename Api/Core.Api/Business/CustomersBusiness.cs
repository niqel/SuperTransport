using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using IO.Swagger.Models;
using AuthenticationHandler.Business;
using System.Linq;
using System.Collections.Generic;
using CrmTc.DAL.Models;
using System.Globalization;

namespace IO.Swagger.Business
{
    public class CustomersBusiness: BusinessBase
    {
        protected CrmTcEntities CrmContext { get; private set; }
        public CustomersBusiness(TmsTcEntities context, CrmTcEntities crmContext, ClaimsPrincipal user) : base(context, user)
        {
            CrmContext = crmContext;
        }

        public ObjectResult GetCustomers()
        {
            var clientesQuery = CrmContext.Clientes.Where(c => c.Active == true).OrderBy(c => c.NombreComercial);

            var customers = GetCustomerQueryable(clientesQuery).ToList();
            return new OkObjectResult(customers);
        }

        public static IQueryable<Customer> GetCustomerQueryable(IQueryable<CrmTc.DAL.Models.Clientes> clientesQuery)
        {
            var customerQueryable = clientesQuery.Select(l => new Customer()
            {
                Id = l.Id,
                Name = l.NombreComercial,
                Description = l.Alias,
                Logo = l.Logo
            });

            return customerQueryable;
        }
    }
}
