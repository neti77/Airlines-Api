using Airline.API.Dto;
using System.Reflection;

namespace Airline.API.Services
{
    public class MySqlAirlineservice : IAirlinesService
    {
        public Models.Airline AddAirline(PostAirlineDto airline)
        {
            throw new NotImplementedException();
        }

        public void DeleteAirline(int id)
        {
            throw new NotImplementedException();
        }

        public List<Models.Airline> GetAllAirlines()
        {
            throw new NotImplementedException();
        }

        public Models.Airline GetAirlineById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Airline UpdateAirline(PutAirlineDto airlineData, int id)
        {
            throw new NotImplementedException();
        }
    }
}
