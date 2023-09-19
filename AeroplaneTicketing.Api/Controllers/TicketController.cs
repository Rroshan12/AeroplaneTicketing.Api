using AeroplaneTicketing.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace AeroplaneTicketing.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {

            _ticketService = ticketService;
        }

        [HttpGet]
        [Route("GetTicketsType")]
        public async Task<IActionResult> GetTicketsType()
        {
            try
            {
                var data = await _ticketService.GetTicketTypes();

                return Ok(data);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NotFound();
        }
    }
}
