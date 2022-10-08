using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using AuthenticationHandler.Business;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace IO.Swagger.Business
{
    public class InternalTransfersBusiness : BusinessBase
    {
        public InternalTransfersBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult AddInternalTransfer(Models.InternalTransfer body)
        {
            var internalTransfer = new InternalTransfer()
            {
                ApprovalStatus = 1,
                Comment = body.Comment,

                InternalTransferHistory = new List<InternalTransferHistory>(),
                InternalTransferTruck = new List<InternalTransferTruck>(),

                Active = true,
                CreatedBy = CurrentUser.Id,
                UpdatedBy = CurrentUser.Id
            };

            internalTransfer.InternalTransferHistory.Add(new InternalTransferHistory
            {
                ApprovalStatus = internalTransfer.ApprovalStatus,
                Comment = internalTransfer.Comment,

                Active = true,
                CreatedBy = CurrentUser.Id,
                UpdatedBy = CurrentUser.Id
            });


            foreach (var truck in body.Trucks)
            {
                internalTransfer.InternalTransferTruck.Add(new InternalTransferTruck
                {
                    Truck = truck.Truck.Value,
                    Origin = truck.Origin.Value,
                    Destination = truck.Destination.Value,

                    Active = true,
                    CreatedBy = CurrentUser.Id,
                    UpdatedBy = CurrentUser.Id
                });
            }

            Context.InternalTransfer.Add(internalTransfer);

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Agregada Correctamente", Detail = "La transferencia interoficina fue agregada correctamente" });
        }

        public ObjectResult GetInternalTransfers()
        {
            var internalTransfers = GetInternalTransfers(Context);
            return new OkObjectResult(internalTransfers);
        }

        public static List<Models.InternalTransfer> GetInternalTransfers(TmsTcEntities context)
        {
            var procesado = Viajes.Api.Enums.InternalTransfers.ApprovalStatus.Procesado.ToString();
            var internalTransfersQuery = context.InternalTransfer.Where(it => it.Active == true && it.ApprovalStatusNavigation.Name != procesado);
            var internalTransfers = internalTransfersQuery.Select(tp => new Models.InternalTransfer()
            {
                Id = tp.Id,

                ApprovalStatus = tp.ApprovalStatus,
                Comment = tp.Comment,

                Trucks = GetTrucks(tp.InternalTransferTruck),

                Active = tp.Active,
                CreatedBy = tp.CreatedBy,
                CreatedAt = tp.CreatedAt,
                UpdatedBy = tp.CreatedBy,
                UpdatedAt = tp.CreatedAt
            }).ToList();
            return internalTransfers;
        }

        private static List<Models.InternalTransferTruck> GetTrucks(ICollection<InternalTransferTruck> internalTransferTruck)
        {
            var trucks = new List<Models.InternalTransferTruck>();
            foreach (var truck in internalTransferTruck)
            {
                trucks.Add(new Models.InternalTransferTruck()
                {
                    Id = truck.Id,

                    Truck = truck.Truck,
                    Origin = truck.Origin,
                    Destination = truck.Destination,

                    Active = truck.Active,
                    CreatedBy = truck.CreatedBy,
                    CreatedAt = truck.CreatedAt,
                    UpdatedBy = truck.UpdatedBy,
                    UpdatedAt = truck.UpdatedAt
                });
            }
            return trucks;
        }

        public ObjectResult UpdateInternalTransfer(Models.InternalTransfer body, int? id)
        {
            var internalTransfer = Context.InternalTransfer.Where(tp => tp.Id == id).FirstOrDefault();
            if (internalTransfer == null)
                return new NotFoundObjectResult(new ProblemDetails() { Status = 404, Title = "No encontrada", Detail = "La transferencia interoficina especificada no existe" });

            internalTransfer.Id = body.Id.Value;

            internalTransfer.ApprovalStatus = body.ApprovalStatus.Value;
            internalTransfer.Comment = body.Comment;

            internalTransfer.UpdatedBy = CurrentUser.Id;
            internalTransfer.UpdatedAt = DateTime.UtcNow.AddHours(-6);


            internalTransfer.InternalTransferHistory.Add(new InternalTransferHistory
            {
                ApprovalStatus = internalTransfer.ApprovalStatus,
                Comment = internalTransfer.Comment,

                Active = true,
                CreatedBy = CurrentUser.Id,
                UpdatedBy = CurrentUser.Id
            });

            Context.SaveChanges();

            return new OkObjectResult(new ProblemDetails() { Status = 200, Title = "Actualizada Correctamente", Detail = "La transferencia interoficina fue actualizada correctamente" });
        }

        public ObjectResult GetInternalTransfersApprovalStatus()
        {
            string[] validApprovalStatus = Enum.GetNames(typeof(Viajes.Api.Enums.InternalTransfers.ApprovalStatus));
            var approvalStatusQuery = Context.ApprovalStatus.Where(aS => aS.Active == true && validApprovalStatus.Contains(aS.Name));
            var approvalStatus = approvalStatusQuery.Select(tp => new Models.NamedEntity()
            {
                Id = tp.Id,

                Name = tp.Name,
                Description = tp.Description,

                Active = tp.Active,
                CreatedBy = tp.CreatedBy,
                CreatedAt = tp.CreatedAt,
                UpdatedBy = tp.CreatedBy,
                UpdatedAt = tp.CreatedAt
            }).ToList();
            return new OkObjectResult(approvalStatus);
        }
    }
}
