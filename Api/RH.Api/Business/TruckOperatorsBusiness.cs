using TmsTcAPI.DAL.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using AuthenticationHandler.Business;
using System.Linq;
using System;
using IO.Swagger.Models;

namespace IO.Swagger.Business
{
    public class TruckOperatorsBusiness : BusinessBase
    {
        public TruckOperatorsBusiness(TmsTcEntities context, ClaimsPrincipal user) : base(context, user)
        {
        }

        public ObjectResult GetTruckOperators()
        {

            //Todo: Esta es la implementacion original
            //var truckOperators = Context.TruckOperator.Where(to => to.Active == true)
            //    .Select(to => new Models.TruckOperator
            //    {
            //        Id = to.Id,
            //        Active = to.Active,
            //        GivenName = to.Employee.GivenName,
            //        PaternalSurname = to.Employee.PaternalSurname,
            //        MaternalSurname = to.Employee.MaternalSurname,
            //        Address = GetAddress(to.Employee.EmployeeAddress.FirstOrDefault()),
            //        Rating = to.Rating,
            //        Type = to.Employee.CEmployeeTypeid,
            //        Truck = GetTruck(to.TruckOperatorTruck.OrderBy(tot => tot.TruckPriority).Select(tot => tot.TruckNavigation).FirstOrDefault()),
            //        ToDo: Corregir consulta de operadores
            //        CreatedBy = to.CreatedBy,
            //        CreatedAt = to.CreatedAt,
            //        UpdatedBy = to.UpdatedBy,
            //        UpdatedAt = to.UpdatedAt
            //    }).ToList();

            //Todo: Se paso la direccion vacio , se debe revisar.
            var operators = (from ope in Context.Operator
                             where ope.Active == true
                             join ad in Context.Addresses on ope.Employeeid equals ad.Employeeid
                             select new TruckOperator()
                             {
                                 Id = ope.Id,
                                 Active = ope.Active,
                                 GivenName = ope.Employee.GivenName,
                                 PaternalSurname = ope.Employee.PaternalSurname,
                                 MaternalSurname = ope.Employee.MaternalSurname,
                                 //Address = GetAddress(to.Employee.EmployeeAddress.FirstOrDefault()),
                                 Address = new Address(),
                                 Rating = ope.Rating,
                                 Type = ope.Employee.CEmployeeTypeid,
                                 //Truck = GetTruck(to.TruckOperatorTruck.OrderBy(tot => tot.TruckPriority).Select(tot => tot.TruckNavigation).FirstOrDefault()),
                                 CreatedBy = ope.CreatedBy,
                                 CreatedAt = ope.CreatedAt,
                                 UpdatedBy = ope.UpdatedBy,
                                 UpdatedAt = ope.UpdatedAt
                             }).ToList();

            return new OkObjectResult(operators);
        }

        //private static Address GetAddress(EmployeeAddress employeeAddress)
        //{
        //    if (employeeAddress == null)
        //        return null;

        //    var address = new Address()
        //    {
        //        Line1 = employeeAddress.Line1,
        //        Line2 = employeeAddress.Line2,
        //        Line3 = employeeAddress.Line3,
        //        City = employeeAddress.City,
        //        State = employeeAddress.State,
        //        PostalCode = employeeAddress.PostalCode,
        //        Country = employeeAddress.Country
        //    };
        //    return address;
        //}

      
        public ObjectResult GetTruckOperatorAvailability(int? id)
        {
            //var truck_operator = Context.TruckOperator.Where(to => to.Id == id.Value).FirstOrDefault();
            var truck_operator = Context.Operator.Where(to => to.Id == id.Value).FirstOrDefault();

            if (truck_operator == null)
            {
                var not_found = new ProblemDetails
                {
                    Title = "Operador no encontrado",
                    Detail = "El operador especificado no existe"
                };
                return new NotFoundObjectResult(not_found);
            }

            var availabilityQuery = Context.CalendarEmployee.Where(ea => ea.Employeeid == truck_operator.Employeeid);
            var availability = availabilityQuery.OrderBy(ea => ea.Date).Select(ea => new Availability
            {
                Date = ea.Date,
                Available = ea.Available,
                AvailabilityReason = ea.CEmployeeUnavailableReasonTypeid,
            }).ToList();

            if(availability.Count == 0)
            {
                availability.Add(new Availability
                {
                    Date = truck_operator.CreatedAt.Date,
                    Available = truck_operator.Active,
                    AvailabilityReason = null,
                    Location = null
                });
            }

            return new OkObjectResult(availability);
        }

        private static Models.Truck GetTruck(TmsTcAPI.DAL.Models.Truck truck)
        {
            if (truck == null)
                return null;

            return new Models.Truck()
            {
                Id = truck.Id,
                Name = truck.Name
            };
        }

        public ObjectResult UpdateTruckOperator(Models.TruckOperator body, int? id)
        {
            //var truck_operator = Context.TruckOperator.Where(to => to.Id == id.Value).FirstOrDefault();
            var truck_operator = Context.Operator.Where(to => to.Id == id.Value).FirstOrDefault();

            if (truck_operator == null)
            {
                var not_found = new ProblemDetails
                {
                    Title = "Operador no encontrado",
                    Detail = "El operador especificado no existe"
                };
                return new NotFoundObjectResult(not_found);
            }

            // TODO: De momento la tarea solo especifica actualizar rating, disponibilidad y razón de disponibilidad
            truck_operator.Rating = body.Rating.Value;
            truck_operator.UpdatedBy = CurrentUser.Id;
            truck_operator.UpdatedAt = DateTime.Now;

            Context.SaveChanges();

            var success = new ProblemDetails
            {
                Title = "Operador actualizado",
                Detail = "El operador especificado se ha actualizado exitosamente"
            };
            return new OkObjectResult(success);
        }

        public ObjectResult UpdateTruckOperatorAvailability(Availability body, int? id)
        {
            //var truck_operator = Context.TruckOperator.Where(to => to.Id == id.Value).FirstOrDefault();
            var truck_operator = Context.Operator.Where(to => to.Id == id.Value).FirstOrDefault();

            if (truck_operator == null)
            {
                var not_found = new ProblemDetails
                {
                    Title = "Operador no encontrado",
                    Detail = "El operador especificado no existe"
                };
                return new NotFoundObjectResult(not_found);
            }

            var availability = Context.CalendarEmployee.Where(ea => ea.Employeeid == truck_operator.Employeeid && ea.Date == body.Date.Value).FirstOrDefault();
            if(availability == null)
            {
                availability = new CalendarEmployee
                {
                    Employeeid = truck_operator.Employeeid,
                    Date = body.Date.Value,
                    Available = body.Available.Value,
                    CEmployeeUnavailableReasonTypeid = (int) body.AvailabilityReason,
                    CreatedBy = CurrentUser.Id,
                };
                Context.CalendarEmployee.Add(availability);
            } else
            {
                availability.Available = body.Available.Value;
                availability.CEmployeeUnavailableReasonTypeid = (int) body.AvailabilityReason;
            }
            Context.SaveChanges();

            var success = new ProblemDetails
            {
                Title = "Disponibiliad actualizada",
                Detail = "La disponibilidad del operador especificado se ha actualizado exitosamente"
            };
            return new OkObjectResult(success);
        }
    }
}
