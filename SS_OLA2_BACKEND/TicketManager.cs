using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND
{
    public class TicketManager
    {
        private DBManager _dBManager;

        public TicketManager(DBManager dBManager)
        {
            _dBManager = dBManager;
        }

        public Ticket ValidateTicket(Ticket ticket) 
        {
            Ticket validatedTicket = _dBManager.ValidateTicket(ticket.DriverFirstName, ticket.DriverLastName, ticket.CompanyName, ticket.ChemicalType);
            return validatedTicket;
        }
    }
}
