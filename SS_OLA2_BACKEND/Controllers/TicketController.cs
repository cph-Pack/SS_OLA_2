using Microsoft.AspNetCore.Mvc;
using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        // GET api/ticket
        [HttpGet]
        public ActionResult<Ticket> Get()
        {
            Ticket ticket = new Ticket("Patrick", "Diekmann", "CPH-Pack", "A", 1);
            // Dette kodestykke behøves ikke, da vi ovenfor opretter en ny ticket med constructor
            //{
            //    ticket.DriverFirstName = "Patrick";
            //    ticket.DriverLastName = "Diekmann";
            //    ticket.CompanyName = "CPH-Pack";
            //    ticket.ChemicalType = "A";
            //    ticket.AmountInKilos = 1;
            //}
           return Ok(ticket);
        }
    }
}
