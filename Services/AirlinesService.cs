using Airline.API.Dto;
using System.Reflection;
using System;

namespace Airline.API.Services
{
    public class AirlinesService : IAirlinesService
    {
        private AppDbContext _context;
        public AirlinesService(AppDbContext context)
        {
            _context = context;
        }


        public List<Models.Airline> GetAllAirlines()
        {
            var allAirlines = _context.Airlines.ToList();
            return allAirlines;
        }

        public Models.Airline AddAirline(PostAirlineDto airline)
        {
            var newAirline = new Models.Airline()
            {
                Name= airline.Name,
                Founding = airline.Founding,
                Pilot = airline.Pilot,


            };

            _context.Airlines.Add(newAirline);
            _context.SaveChanges();

            return newAirline;
        }

        public void DeleteAirline(int id)
        {
            var airlineDb = _context.Airlines
                .FirstOrDefault(n => n.Id == id);

            _context.Airlines.Remove(airlineDb);
            _context.SaveChanges();
        }



        public Models.Airline GetAirlineById(int id)
        {
            var newAirline = _context.Airlines
                .FirstOrDefault(n => n.Id == id);
            return newAirline;
        }

        public Models.Airline UpdateAirline(PutAirlineDto airlineData, int id)
        {
            var airlineDb = _context.Airlines
                .FirstOrDefault(n => n.Id == id);

            airlineDb.Name = airlineData.Name;
            _context.Airlines.Update(airlineDb);

            _context.SaveChanges();

            return airlineDb;
        }
    }
}
