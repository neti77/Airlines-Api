using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Airline.API.Dto;
using Airline.API.Services;

namespace Airline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        private IAirlinesService _service;
        public AirlinesController(IAirlinesService service)
        {
            _service = service;
        }

        [HttpGet("All")]
        public IActionResult GetAirlines()
        {
            //List of airlines
            var allAirlines = _service.GetAllAirlines();

            return Ok(allAirlines);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetAirlineById(int id)
        {
            var newAirline = _service.GetAirlineById(id);

            if (newAirline == null)
                return NotFound($"Airline with id {id} could not be found.");

            return Ok(newAirline);
        }


        [HttpPost]
        public IActionResult AddNewAirline([FromBody] PostAirlineDto payload)
        {
            var newAirline = _service.AddAirline(payload);

            return Ok(newAirline);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateAirline([FromBody] PutAirlineDto payload, int id)
        {
            var updatedAirline = _service.UpdateAirline(payload, id);

            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteAirline(int id)
        {
            _service.DeleteAirline(id);

            return Ok();
        }

    }
}
