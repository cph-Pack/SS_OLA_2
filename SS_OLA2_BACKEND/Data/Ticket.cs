using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SS_OLA2_BACKEND.Data
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }
        // Chauffør information
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }

        // Virksomhedsinformation
        public string CompanyName { get; set; }

        // Forsendelsesdetaljer
        public string ChemicalType { get; set; } // A, B eller C
        public int AmountInKilos { get; set; } // Mængden i kilo

        // Constructor til initialisering af ticket
        public Ticket(string driverFirstName, string driverLastName, string companyName, string chemicalType, int amountInKilos)
        {
            // Initialiserer felterne
            DriverFirstName = driverFirstName;
            DriverLastName = driverLastName;
            CompanyName = companyName;

            // Tjekker om kemikalietypen er korrekt (A, B eller C)
            if (chemicalType != "A" && chemicalType != "B" && chemicalType != "C")
            {
                throw new ArgumentException("Chemical type must be A, B, or C.");
            }
            ChemicalType = chemicalType;

            // Tjekker om mængden er gyldig (ikke negativ)
            if (amountInKilos < 0)
            {
                throw new ArgumentException("Amount in kilos cannot be negative.");
            }
            AmountInKilos = amountInKilos;
        }
    }
}
