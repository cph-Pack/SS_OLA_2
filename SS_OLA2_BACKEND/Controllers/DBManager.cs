using MongoDB.Driver;
using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND.Controllers
{
    public class DBManager
    {
        private const string connectionUri = "mongodb://localhost:27017";
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Ticket> _TicketCollection;
        private readonly IMongoCollection<JobClass> _JobCollection;

        public DBManager()
        {
            _client = new MongoClient(connectionUri);
            _database = _client.GetDatabase("Warehouse");
            _JobCollection = _database.GetCollection<JobClass>("Job");
            _TicketCollection = _database.GetCollection<Ticket>("Ticket");
        }
    }
}
