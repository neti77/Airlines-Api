using Airline.API.Dto;
using System.Reflection;

namespace Airline.API.Services
{
    public interface IAirlinesService
    {
        List<Models.Airline> GetAllAirlines();
        Models.Airline GetAirlineById(int id);
        Models.Airline AddAirline(PostAirlineDto airline);
        Models.Airline UpdateAirline(PutAirlineDto airlineData, int id);
        void DeleteAirline(int id);
    }
}
