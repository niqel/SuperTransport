using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using AuthenticationHandler.Business;
using System.Linq;
using System;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace IO.Swagger.Business
{
    public class EmployeesBusiness: BusinessBase
    {
        public EmployeesBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public void SetOperatorsStatusByDay()
        {
            string procedimiento = "SP_ObtenerEstatusOperadores";
            var con = (SqlConnection)Context.Database.GetDbConnection();

            using (SqlConnection cn = new SqlConnection(con.ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
            }
        }

        public ObjectResult GetEmployeeTypes()
        {
            var employeeTypes = Context.CEmployeeType.Where(et => et.Active == true)
                .Select(et => new Models.EmployeeType {
                    Id = et.Id,
                    Name = et.Name,
                    Description = et.Description,
                    Active = et.Active,
                    CreatedBy = et.CreatedBy,
                    CreatedAt = et.CreatedAt,
                    UpdatedBy = et.UpdatedBy,
                    UpdatedAt = et.UpdatedAt
            }).ToList();
            return new OkObjectResult(employeeTypes);
        }

        public ObjectResult GetEmployeeAvailabilityReasons(int? id)
        {
            //var availabilityReasons = Context.EmployeeAvailabilityReason.Where(et => et.Active == true && et.EmployeeType == id)
            var availabilityReasons = Context.CEmployeeUnavailableReasonType.Where(et => et.Active == true)
                .Select(et => new Models.AvailabilityReason
                {
                    Id = et.Id,
                    Name = et.Name,
                    Description = et.Description,
                    Active = et.Active,
                    CreatedBy = et.CreatedBy,
                    CreatedAt = et.CreatedAt.UtcDateTime,
                    UpdatedBy = et.UpdatedBy,
                    UpdatedAt = et.UpdatedAt.UtcDateTime
                }).ToList();
            return new OkObjectResult(availabilityReasons);
        }

        public void SincronizarEmpleados()
        {
            string procedimiento = "SP_Sincronizar_Empleados";
            var con = (SqlConnection)Context.Database.GetDbConnection();

            using (SqlConnection cn = new SqlConnection(con.ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(procedimiento, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
            }
        }
    }
}
