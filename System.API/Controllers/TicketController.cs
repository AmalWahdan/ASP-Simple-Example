using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.BL;
using System.DAL;

namespace System.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketManager _ticketManager;

        public TicketController(ITicketManager ticketManager)
        {
            _ticketManager = ticketManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TicketCrudeDtos>> GetAllTickets()
        {
            var tickets = _ticketManager.GetAll();
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        public ActionResult<TicketCrudeDtos> GetTicketById(int id)
        {
            var ticket = _ticketManager.GetTicketById(id);
            if (ticket == null)
            {
                return NotFound();
            }
            return Ok(ticket);
        }

        [HttpPost]
        public ActionResult<TicketCrudeDtos> AddTicket(TicketCrudeDtos ticket)
        {
            _ticketManager.Add(ticket);
            return CreatedAtAction(nameof(GetTicketById), new { id = ticket.Id }, ticket);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTicket(int id, TicketCrudeDtos ticket)
        {
            if ( ticket.Id != id )
            {
                return BadRequest();
            }

            _ticketManager.Update(ticket);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            _ticketManager.Delete(id);

            return NoContent();
        }







    }
}
