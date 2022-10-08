using AuthenticationHandler.Business;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TmsTcAPI.DAL.Models;

namespace Viajes.Api.Business
{
    public class HotelBusiness : BusinessBase
    {
        protected TmsTcEntities TmsTcEntities { get; private set; }

        public HotelBusiness(TmsTcEntities tmsTcEntities, ClaimsPrincipal user) : base(tmsTcEntities, user)
        {
            this.TmsTcEntities = tmsTcEntities;
        }
        public ObjectResult HotelGet()
        {
            RHotel rHotel = new RHotel();

            rHotel.Reply = new Reply();

            try
            {
                var entitiesHotel = this.TmsTcEntities.Hotels.ToList();
                rHotel.Data = new HotelData();
                rHotel.Data.Hotels = (from entity in entitiesHotel

                                      select new IO.Swagger.Models.Hotel()
                                      {
                                          Id = entity.Id,
                                          Description = entity.Description,
                                          Latitude = entity.Latitude,
                                          Longitude = entity.Longitude,
                                          Name = entity.Name,
                                          Key = entity.Key,
                                          Email = entity.Email,
                                          Phone = entity.Phone,
                                          Website = entity.Website
                                      }).ToList();
            }
            catch (Exception ex)
            {
                rHotel.Reply.Code = 400;
                rHotel.Reply.Message = ex.Message;
            }

            rHotel.Reply.Code = 200;
            rHotel.Reply.Message = "OK";
            return new ObjectResult(rHotel);
        }

        public CreatedId HotelPost(IO.Swagger.Models.Hotel hotel)
        {
            TmsTcAPI.DAL.Models.Hotels hotels = new Hotels()
            {
                Description = hotel.Description,
                Latitude = hotel.Latitude,
                Longitude = hotel.Longitude,
                Name = hotel.Name,
                Key = hotel.Key,
                Email = hotel.Email,
                Phone = hotel.Phone,
                Website = hotel.Website,
                Active = true,
                CreatedBy = -1, //base.CurrentUser.Id,
                CreatedAt = DateTime.Now,
                UpdatedBy = -1,// CurrentUser.Id,
                UpdatedAt = DateTime.Now
            };

            TmsTcEntities.Hotels.Add(hotels);
            TmsTcEntities.SaveChanges();

            CreatedId createdId = new CreatedId();
            createdId.Id = hotels.Id;
            return createdId;
        }

        public ObjectResult GetByRouteId(int? routeId)
        {
            RHotel rHotel = new RHotel();

            rHotel.Reply = new Reply();

            try
            {
                var entitiesHotelsByRoute = this.TmsTcEntities.RoutesHotels.Include(x => x.Hotels).Where(x => x.RouteId == routeId);

                rHotel.Data = new HotelData();
                rHotel.Data.Hotels = new List<Hotel>();

                foreach (var route in entitiesHotelsByRoute)
                {
                    IO.Swagger.Models.Hotel hotel = new Hotel()
                    {
                        Id = route.Hotels.Id,
                        Key = route.Hotels.Key,
                        Description = route.Hotels.Description,
                        Email = route.Hotels.Email,
                        Latitude = route.Hotels.Latitude,
                        Longitude = route.Hotels.Longitude,
                        Name = route.Hotels.Name,
                        Phone = route.Hotels.Phone,
                        Website = route.Hotels.Website
                    };
                    rHotel.Data.Hotels.Add(hotel);
                }
            }
            catch (Exception ex)
            {
                rHotel.Reply.Code = 400;
                rHotel.Reply.Message = ex.Message;
            }

            rHotel.Reply.Code = 200;
            rHotel.Reply.Message = "OK";
            return new ObjectResult(rHotel);
        }
    }
}
