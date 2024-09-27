using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND
{
    public class TicketService
    {
        private DBManager _dbManager;
        private TicketManager _ticketManager;
        private JobManager _jobManager;

        public TicketService() 
        { 
            _dbManager = new DBManager();
            _ticketManager = new TicketManager(_dbManager);
            _jobManager = new JobManager(_dbManager);
        }

        public Job ProcessTicket(Ticket ticket)
        {
            // Validate the ticket
            Ticket validatedTicket = _ticketManager.ValidateTicket(ticket);
            if (validatedTicket == null)
            {
                throw new InvalidOperationException("Invalid Ticket");
            }
            // should get jobType from ticket probably, but it isn't in the user story
            Job newJob = _jobManager.CreateJob(JobType.Collection);
            return newJob;
        }
    }
}
