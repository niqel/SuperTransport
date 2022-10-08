using AuthenticationHandler.Business;
using CrmTc.DAL.Models;
using InnovaLinks.DAL.Models;
using IO.Swagger.Models;
using ListdbTc.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;
using NonBudgetedExpense = IO.Swagger.Models.NonBudgetedExpense;

namespace Viajes.Api.Business
{
    public class NonBudgetedExpenseBusiness : BusinessBase
    {
        protected TmsTcEntities TmsContext { get; private set; }
        protected CrmTcEntities CrmTcEntities { get; private set; }
        public NonBudgetedExpenseBusiness(TmsTcEntities context, CrmTcEntities crmTcEntities, ClaimsPrincipal user) : base(context, user)
        {
            TmsContext = context;
            CrmTcEntities = crmTcEntities;
        }

        public ObjectResult GetAllByDateNonBudgetedExpense(DateTime? date)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data = new RNonBudgetedExpenseData();
            rNonBudgetedExpense.Data.NonBudgetedExpense = new List<NonBudgetedExpense>();

            var oficinas = CrmTcEntities.OficinasOperativas.ToList();
            var destinos = CrmTcEntities.Destinos;

            var NonBudgetedExpense = TmsContext.NonBudgetedExpense.Where(x => x.UpdatedAt.Date == date)
                .Include(x => x.NonBudgetedExpenseStatus)
                .Include(x => x.NonBudgetedExpenseType)
                .Include(x => x.Operator).ThenInclude(x => x.Employee)
                .Include(x => x.Trip)
                .ToList();

         
            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in NonBudgetedExpense

                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatusId = nbe.NonBudgetedExpenseStatusId,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbe.NonBudgetedExpenseStatus.Description
                                                               },
                                                               Date = nbe.UpdatedAt.Date,
                                                               NonBudgetedExpenseTypeId = nbe.NonBudgetedExpenseTypeId,
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbe.NonBudgetedExpenseType.Description
                                                               },
                                                               OperatorId = nbe.OperatorId,
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               Trip = new Trip()
                                                               {
                                                                   Id = nbe.TripId,
                                                                   DestinationId = nbe.Trip.Destination,
                                                                   Destination = new Destination()
                                                                   {
                                                                       Id = nbe.Trip.Destination
                                                                   },
                                                                   OriginId = nbe.Trip.Origin,
                                                                   Origin = new Origin()
                                                                   {
                                                                       Id = nbe.Trip.Origin
                                                                   },
                                                                   ReturnToId = nbe.Trip.ReturnTo,
                                                                   ReturnTo = new ReturnTo()
                                                                   { 
                                                                       Id = nbe.Trip.ReturnTo
                                                                   },
                                                                   TripZamId = nbe.Trip.Idtravelzam,
                                                               },
                                                           }).ToList();

            foreach (var nbe in rNonBudgetedExpense.Data.NonBudgetedExpense)
            {
                nbe.Trip.Origin.Description = oficinas.Where(x => x.Id == nbe.Trip.Origin.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
                nbe.Trip.Destination.Description = destinos.Where(x => x.Id == nbe.Trip.Destination.Id).Select(x => x.Nombre).FirstOrDefault();
                nbe.Trip.ReturnTo.Description = oficinas.Where(x => x.Id == nbe.Trip.ReturnTo.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
            }

            return new ObjectResult(rNonBudgetedExpense);
        }

        public ObjectResult GetAllByIdStatusNonBudgetedExpense(int? idStatus)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data = new RNonBudgetedExpenseData();
            rNonBudgetedExpense.Data.NonBudgetedExpense = new List<NonBudgetedExpense>();

            var oficinas = CrmTcEntities.OficinasOperativas.ToList();
            var destinos = CrmTcEntities.Destinos;
            var NonBudgetedExpense = TmsContext.NonBudgetedExpense.Where(x => x.NonBudgetedExpenseStatusId == idStatus)
                .Include(x => x.NonBudgetedExpenseStatus)
                .Include(x => x.NonBudgetedExpenseType)
                .Include(x => x.Operator).ThenInclude(x => x.Employee)
                .Include(x => x.Trip)
                .ToList();

            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in NonBudgetedExpense

                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatusId = nbe.NonBudgetedExpenseStatusId,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbe.NonBudgetedExpenseStatus.Description
                                                               },
                                                               Date = nbe.UpdatedAt.Date,
                                                               NonBudgetedExpenseTypeId = nbe.NonBudgetedExpenseTypeId,
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbe.NonBudgetedExpenseType.Description
                                                               },
                                                               OperatorId = nbe.OperatorId,
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               Trip = new Trip()
                                                               {
                                                                   Id = nbe.TripId,
                                                                   DestinationId = nbe.Trip.Destination,
                                                                   Destination = new Destination()
                                                                   {
                                                                       Id = nbe.Trip.Destination
                                                                   },
                                                                   OriginId = nbe.Trip.Origin,
                                                                   Origin = new Origin()
                                                                   {
                                                                       Id = nbe.Trip.Origin
                                                                   },
                                                                   ReturnToId = nbe.Trip.ReturnTo,
                                                                   ReturnTo = new ReturnTo()
                                                                   {
                                                                       Id = nbe.Trip.ReturnTo
                                                                   },
                                                                   TripZamId = nbe.Trip.Idtravelzam,
                                                               },
                                                           }).ToList();

            foreach (var nbe in rNonBudgetedExpense.Data.NonBudgetedExpense)
            {
                nbe.Trip.Origin.Description = oficinas.Where(x => x.Id == nbe.Trip.Origin.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
                nbe.Trip.Destination.Description = destinos.Where(x => x.Id == nbe.Trip.Destination.Id).Select(x => x.Nombre).FirstOrDefault();
                nbe.Trip.ReturnTo.Description = oficinas.Where(x => x.Id == nbe.Trip.ReturnTo.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
            }

            rNonBudgetedExpense.Reply = new Reply();

            if (rNonBudgetedExpense.Data.NonBudgetedExpense.Count > 0)
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros encontrados";
            }
            else
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rNonBudgetedExpense);
        }

        public ObjectResult GetAllByTripNonBudgetedExpense(int? idTrip)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data = new RNonBudgetedExpenseData();
            rNonBudgetedExpense.Data.NonBudgetedExpense = new List<NonBudgetedExpense>();

            var oficinas = CrmTcEntities.OficinasOperativas.ToList();
            var destinos = CrmTcEntities.Destinos;
            var NonBudgetedExpense = TmsContext.NonBudgetedExpense.Where(x => x.TripId == idTrip)
                .Include(x => x.NonBudgetedExpenseStatus)
                .Include(x => x.NonBudgetedExpenseType)
                .Include(x => x.Operator).ThenInclude(x => x.Employee)
                .Include(x => x.Trip)
                .ToList();

            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in NonBudgetedExpense

                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatusId = nbe.NonBudgetedExpenseStatusId,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbe.NonBudgetedExpenseStatus.Description
                                                               },
                                                               Date = nbe.UpdatedAt.Date,
                                                               NonBudgetedExpenseTypeId = nbe.NonBudgetedExpenseTypeId,
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbe.NonBudgetedExpenseType.Description
                                                               },
                                                               OperatorId = nbe.OperatorId,
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               Trip = new Trip()
                                                               {
                                                                   Id = nbe.TripId,
                                                                   DestinationId = nbe.Trip.Destination,
                                                                   Destination = new Destination()
                                                                   {
                                                                       Id = nbe.Trip.Destination
                                                                   },
                                                                   OriginId = nbe.Trip.Origin,
                                                                   Origin = new Origin()
                                                                   {
                                                                       Id = nbe.Trip.Origin
                                                                   },
                                                                   ReturnToId = nbe.Trip.ReturnTo,
                                                                   ReturnTo = new ReturnTo()
                                                                   {
                                                                       Id = nbe.Trip.ReturnTo
                                                                   },
                                                                   TripZamId = nbe.Trip.Idtravelzam,
                                                               },
                                                           }).ToList();

            foreach (var nbe in rNonBudgetedExpense.Data.NonBudgetedExpense)
            {
                nbe.Trip.Origin.Description = oficinas.Where(x => x.Id == nbe.Trip.Origin.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
                nbe.Trip.Destination.Description = destinos.Where(x => x.Id == nbe.Trip.Destination.Id).Select(x => x.Nombre).FirstOrDefault();
                nbe.Trip.ReturnTo.Description = oficinas.Where(x => x.Id == nbe.Trip.ReturnTo.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
            }

            rNonBudgetedExpense.Reply = new Reply();

            if (rNonBudgetedExpense.Data.NonBudgetedExpense.Count > 0)
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros encontrados";
            }
            else
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rNonBudgetedExpense);
        }

        public ObjectResult GetAllNonBudgetedExpense()
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data = new RNonBudgetedExpenseData();
            rNonBudgetedExpense.Data.NonBudgetedExpense = new List<NonBudgetedExpense>();

            var oficinas = CrmTcEntities.OficinasOperativas.ToList();
            var destinos = CrmTcEntities.Destinos;
            var NonBudgetedExpense = TmsContext.NonBudgetedExpense
                .Include(x => x.NonBudgetedExpenseStatus)
                .Include(x => x.NonBudgetedExpenseType)
                .Include(x => x.Operator).ThenInclude(x => x.Employee)
                .Include(x => x.Trip)
                .ToList();

            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in NonBudgetedExpense

                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatusId = nbe.NonBudgetedExpenseStatusId,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbe.NonBudgetedExpenseStatus.Description
                                                               },
                                                               Date = nbe.UpdatedAt.Date,
                                                               NonBudgetedExpenseTypeId = nbe.NonBudgetedExpenseTypeId,
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbe.NonBudgetedExpenseType.Description
                                                               },
                                                               OperatorId = nbe.OperatorId,
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               Trip = new Trip()
                                                               {
                                                                   Id = nbe.TripId,
                                                                   DestinationId = nbe.Trip.Destination,
                                                                   Destination = new Destination()
                                                                   {
                                                                       Id = nbe.Trip.Destination
                                                                   },
                                                                   OriginId = nbe.Trip.Origin,
                                                                   Origin = new Origin()
                                                                   {
                                                                       Id = nbe.Trip.Origin
                                                                   },
                                                                   ReturnToId = nbe.Trip.ReturnTo,
                                                                   ReturnTo = new ReturnTo()
                                                                   {
                                                                       Id = nbe.Trip.ReturnTo
                                                                   },
                                                                   TripZamId = nbe.Trip.Idtravelzam,
                                                               },
                                                           }).ToList();

            foreach (var nbe in rNonBudgetedExpense.Data.NonBudgetedExpense)
            {
                nbe.Trip.Origin.Description = oficinas.Where(x => x.Id == nbe.Trip.Origin.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
                nbe.Trip.Destination.Description = destinos.Where(x => x.Id == nbe.Trip.Destination.Id).Select(x => x.Nombre).FirstOrDefault();
                nbe.Trip.ReturnTo.Description = oficinas.Where(x => x.Id == nbe.Trip.ReturnTo.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
            }

            rNonBudgetedExpense.Reply = new Reply();

            if (rNonBudgetedExpense.Data.NonBudgetedExpense.Count > 0)
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros encontrados";
            }
            else
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rNonBudgetedExpense);
        }

        public ObjectResult GetByIdNonBudgetedExpense(int? id)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data = new RNonBudgetedExpenseData();
            rNonBudgetedExpense.Data.NonBudgetedExpense = new List<NonBudgetedExpense>();

            var oficinas = CrmTcEntities.OficinasOperativas.ToList();
            var destinos = CrmTcEntities.Destinos;
            var NonBudgetedExpense = TmsContext.NonBudgetedExpense.Where(x => x.Id == id)
                .Include(x => x.NonBudgetedExpenseStatus)
                .Include(x => x.NonBudgetedExpenseType)
                .Include(x => x.Operator).ThenInclude(x => x.Employee)
                .Include(x => x.Trip)
                .ToList();

            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in NonBudgetedExpense

                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatusId = nbe.NonBudgetedExpenseStatusId,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbe.NonBudgetedExpenseStatus.Description
                                                               },
                                                               Date = nbe.UpdatedAt.Date,
                                                               NonBudgetedExpenseTypeId = nbe.NonBudgetedExpenseTypeId,
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbe.NonBudgetedExpenseType.Description
                                                               },
                                                               OperatorId = nbe.OperatorId,
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               Trip = new Trip()
                                                               {
                                                                   Id = nbe.TripId,
                                                                   DestinationId = nbe.Trip.Destination,
                                                                   Destination = new Destination()
                                                                   {
                                                                       Id = nbe.Trip.Destination
                                                                   },
                                                                   OriginId = nbe.Trip.Origin,
                                                                   Origin = new Origin()
                                                                   {
                                                                       Id = nbe.Trip.Origin
                                                                   },
                                                                   ReturnToId = nbe.Trip.ReturnTo,
                                                                   ReturnTo = new ReturnTo()
                                                                   {
                                                                       Id = nbe.Trip.ReturnTo
                                                                   },
                                                                   TripZamId = nbe.Trip.Idtravelzam,
                                                               },
                                                           }).ToList();

            foreach (var nbe in rNonBudgetedExpense.Data.NonBudgetedExpense)
            {
                nbe.Trip.Origin.Description = oficinas.Where(x => x.Id == nbe.Trip.Origin.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
                nbe.Trip.Destination.Description = destinos.Where(x => x.Id == nbe.Trip.Destination.Id).Select(x => x.Nombre).FirstOrDefault();
                nbe.Trip.ReturnTo.Description = oficinas.Where(x => x.Id == nbe.Trip.ReturnTo.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
            }

            rNonBudgetedExpense.Reply = new Reply();

            if (rNonBudgetedExpense.Data.NonBudgetedExpense.Count > 0)
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros encontrados";
            }
            else
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rNonBudgetedExpense);
        }

        public List<NonBudgetedExpense> GetModelByIdNonBudgetedExpense(int? id)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in this.TmsContext.NonBudgetedExpense
                                                           join nbes in this.TmsContext.CNonBudgetedExpenseStatus on nbe.NonBudgetedExpenseStatusId equals nbes.Id
                                                           join nbet in this.TmsContext.CNonBudgetedExpenseType on nbe.NonBudgetedExpenseTypeId equals nbet.Id
                                                           join ope in this.TmsContext.Operator on nbe.OperatorId equals ope.Id
                                                           join emp in this.TmsContext.Employee on nbe.Operator.Employeeid equals emp.Id
                                                           join tri in this.TmsContext.Trips on nbe.TripId equals tri.Id
                                                           where nbe.Id == id
                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbes.Description,
                                                               },
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbet.Description
                                                               },
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               //Trip = new Trip()
                                                               //{
                                                               //    Id = nbe.TripId,
                                                               //    Destination = new Destination()
                                                               //    {

                                                               //    },
                                                               //    Origin = new Origin()
                                                               //    {
                                                               //    },
                                                               //    ReturnToZamId = tri.Idregresozam,
                                                               //    TripZamId = tri.Idtravelzam
                                                               //},
                                                           }).ToList();
            return rNonBudgetedExpense.Data.NonBudgetedExpense;
        }

        public ObjectResult GetByIdOperatorIdTripNonBudgetedExpense(int? idOperator, int? idTrip)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            rNonBudgetedExpense.Data = new RNonBudgetedExpenseData();
            rNonBudgetedExpense.Data.NonBudgetedExpense = new List<NonBudgetedExpense>();

            var oficinas = CrmTcEntities.OficinasOperativas.ToList();
            var destinos = CrmTcEntities.Destinos;
            var NonBudgetedExpense = TmsContext.NonBudgetedExpense.Where(x => x.OperatorId == idOperator && x.TripId == idTrip)
                .Include(x => x.NonBudgetedExpenseStatus)
                .Include(x => x.NonBudgetedExpenseType)
                .Include(x => x.Operator).ThenInclude(x => x.Employee)
                .Include(x => x.Trip)
                .ToList();

            rNonBudgetedExpense.Data.NonBudgetedExpense = (from nbe in NonBudgetedExpense

                                                           select new NonBudgetedExpense()
                                                           {
                                                               Id = nbe.Id,
                                                               NonBudgetedExpenseStatusId = nbe.NonBudgetedExpenseStatusId,
                                                               NonBudgetedExpenseStatus = new NonBudgetedExpenseStatus()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseStatusId,
                                                                   Name = nbe.NonBudgetedExpenseStatus.Description
                                                               },
                                                               Date = nbe.UpdatedAt.Date,
                                                               NonBudgetedExpenseTypeId = nbe.NonBudgetedExpenseTypeId,
                                                               NonBudgetedExpenseType = new NonBudgetedExpenseType()
                                                               {
                                                                   Id = nbe.NonBudgetedExpenseTypeId,
                                                                   Name = nbe.NonBudgetedExpenseType.Description
                                                               },
                                                               OperatorId = nbe.OperatorId,
                                                               Operator = new IO.Swagger.Models.Operator()
                                                               {
                                                                   Id = nbe.OperatorId,
                                                                   Name = nbe.Operator.Employee.GivenName
                                                               },
                                                               Amount = Convert.ToDouble(nbe.Amount),
                                                               Comments = nbe.Comment,
                                                               IsBillable = nbe.IsBillable,
                                                               Trip = new Trip()
                                                               {
                                                                   Id = nbe.TripId,
                                                                   DestinationId = nbe.Trip.Destination,
                                                                   Destination = new Destination()
                                                                   {
                                                                       Id = nbe.Trip.Destination
                                                                   },
                                                                   OriginId = nbe.Trip.Origin,
                                                                   Origin = new Origin()
                                                                   {
                                                                       Id = nbe.Trip.Origin
                                                                   },
                                                                   ReturnToId = nbe.Trip.ReturnTo,
                                                                   ReturnTo = new ReturnTo()
                                                                   {
                                                                       Id = nbe.Trip.ReturnTo
                                                                   },
                                                                   TripZamId = nbe.Trip.Idtravelzam,
                                                               },
                                                           }).ToList();

            foreach (var nbe in rNonBudgetedExpense.Data.NonBudgetedExpense)
            {
                nbe.Trip.Origin.Description = oficinas.Where(x => x.Id == nbe.Trip.Origin.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
                nbe.Trip.Destination.Description = destinos.Where(x => x.Id == nbe.Trip.Destination.Id).Select(x => x.Nombre).FirstOrDefault();
                nbe.Trip.ReturnTo.Description = oficinas.Where(x => x.Id == nbe.Trip.ReturnTo.Id).Select(x => x.Oficinas.Nombre).FirstOrDefault();
            }

            rNonBudgetedExpense.Reply = new Reply();

            if (rNonBudgetedExpense.Data.NonBudgetedExpense.Count > 0)
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros encontrados";
            }
            else
            {
                rNonBudgetedExpense.Reply.Code = 200;
                rNonBudgetedExpense.Reply.Message = "Registros No encontrados";
            }

            return new ObjectResult(rNonBudgetedExpense);
        }
        public CreatedId NonBudgetedExpensePost(NonBudgetedExpense nonBudgetedExpense)
        {
            TmsTcAPI.DAL.Models.NonBudgetedExpense entityNonBudgetedExpense = new TmsTcAPI.DAL.Models.NonBudgetedExpense()
            {
                //Id = Convert.ToInt32(nonBudgetedExpense.Id),
                Active = true,
                Amount = Convert.ToDecimal(nonBudgetedExpense.Amount),
                Comment = nonBudgetedExpense.Comments,
                CreatedAt = DateTime.Now,
                CreatedBy = -1,//CurrentUser.Id,
                IsBillable = nonBudgetedExpense.IsBillable,
                TripId = Convert.ToInt32(nonBudgetedExpense.TripId),
                OperatorId = Convert.ToInt32(nonBudgetedExpense.OperatorId),
                NonBudgetedExpenseStatusId = Context.CNonBudgetedExpenseStatus.Where(x => x.Key == "init").Select(x => x.Id).FirstOrDefault(),
                NonBudgetedExpenseTypeId = Convert.ToInt32(nonBudgetedExpense.NonBudgetedExpenseTypeId),
                UpdatedAt = DateTime.Now,
                UpdatedBy = -1//CurrentUser.Id

            };
            this.TmsContext.NonBudgetedExpense.Add(entityNonBudgetedExpense);
            this.TmsContext.SaveChanges();
            CreatedId createdId = new CreatedId();
            createdId.Id = entityNonBudgetedExpense.Id;
            return createdId;
        }

        public ObjectResult UpdateExternalNonBudgetedExpense(int? idOperator, int? idTrip)
        {
            RNonBudgetedExpense rNonBudgetedExpense = new RNonBudgetedExpense();
            return new ObjectResult(null);
        }

        public ObjectResult UpdateNonBudgetedExpense(NonBudgetedExpense nonBudgetedExpense, int? id)
        {
            var entity = this.TmsContext.NonBudgetedExpense.Where(x => x.Id == id).FirstOrDefault();

            entity.Active = true;
            entity.Amount = Convert.ToDecimal(nonBudgetedExpense.Amount);
            entity.Comment = nonBudgetedExpense.Comments;
            entity.IsBillable = nonBudgetedExpense.IsBillable;
            entity.TripId = Convert.ToInt32(nonBudgetedExpense.TripId);
            entity.OperatorId = Convert.ToInt32(nonBudgetedExpense.OperatorId);
            entity.NonBudgetedExpenseStatusId = Convert.ToInt32(nonBudgetedExpense.NonBudgetedExpenseStatusId);
            entity.NonBudgetedExpenseTypeId = Convert.ToInt32(nonBudgetedExpense.NonBudgetedExpenseTypeId);
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = -1; //CurrentUser.Id;

            this.TmsContext.NonBudgetedExpense.Update(entity);
            this.Context.SaveChanges();

            return new ObjectResult(204);
        }
    }
}
