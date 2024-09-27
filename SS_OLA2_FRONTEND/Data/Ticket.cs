using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SS_OLA2_FRONTEND.Data
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Required]
        public string DriverFirstName { get; set; }
        [Required]
        public string DriverLastName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ChemicalType { get; set; }
        [Required]
        public int AmountInKilos { get; set; }
    }
}
