using Microsoft.AspNetCore.Mvc;
using SS_OLA2_BACKEND.Data;
using System.Formats.Asn1;

namespace SS_OLA2_BACKEND.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly TicketService ticketService = new TicketService();

        // GET /ticket
        [HttpGet]
        public ActionResult<Ticket> Get()
        {
            string firstName = "Patrick";
            string lastName = "Diekmann";
            string companyName = "CPH-Pack";
            string chemicalType = "A";
            int AmountInKilos = 1;

            Ticket ticket = new Ticket(firstName,lastName, companyName, chemicalType, AmountInKilos);
            return Ok(ticket);
        }

        [HttpPost]
        public ActionResult<Job> Create([FromBody] Ticket ticket)
        {
            try
            {
                Job job = ticketService.ProcessTicket(ticket);
                return (Ok(job));
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
