using Microsoft.AspNetCore.Mvc;
using SS_OLA2_BACKEND.Data;
using System.Formats.Asn1;

namespace SS_OLA2_BACKEND.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        // GET /ticket
        [HttpGet]
        public ActionResult<Ticket> Get()
        {
            Ticket ticket = new Ticket();
            {
                ticket.FirstName = "Patrick";
                ticket.LastName = "Diekmann";
                ticket.CompanyName = "CPH-Pack";
                ticket.ChemicalType = "A";
                ticket.KilogramWeight = 1;
            }
            return Ok(ticket);
        }

        [HttpPost]
        public ActionResult<Ticket> Create([FromBody] Ticket ticket)
        {
            try
            {
                return (Ok(ticket));

            }
            catch (Exception)
            {

                return NotFound("error");
            }
        }
    }
}
