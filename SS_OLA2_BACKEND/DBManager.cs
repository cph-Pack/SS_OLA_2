using MongoDB.Driver;
using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND
{
    public class DBManager
    {
        private const string connectionUri = "mongodb://localhost:27017";
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        private readonly IMongoCollection<Ticket> _ticketCollection;
        private readonly IMongoCollection<Job> _jobCollection;

        public DBManager()
        {
            _client = new MongoClient(connectionUri);
            _database = _client.GetDatabase("SS");

            _ticketCollection = _database.GetCollection<Ticket>("Tickets");
            _jobCollection = _database.GetCollection<Job>("Jobs");
        }

        public Ticket ValidateTicket(string driverFirstName, string driverLastName, string companyName, string chemicalType)
        {
            // Søger i databasen efter en unik ticket
            var ticket = _ticketCollection.Find(t =>
                t.DriverFirstName == driverFirstName &&
                t.DriverLastName == driverLastName &&
                t.CompanyName == companyName &&
                t.ChemicalType == chemicalType).FirstOrDefault();

            // Hvis ingen ticket findes, returneres null (eller du kan kaste en exception)
            if (ticket == null)
            {
                throw new ArgumentException("Ticket not found: Invalid details provided.");
            }

            // Returnerer ticket hvis fundet
            return ticket;
        }

        internal Job SaveJob(Job job)
        {
            _jobCollection.InsertOne(job);
            return job;
        }
    }
}
