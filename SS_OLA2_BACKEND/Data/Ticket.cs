using System.ComponentModel.DataAnnotations;

namespace SS_OLA2_BACKEND.Data
{
    public class Ticket
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CompanyName { get; set; }

        [Required]
        public Chemicals Chemicals { get; set; }

        [Required]
        public string ShipmentType { get; set; }

        public Ticket(string firstName, string lastName, string companyName, string shipmentType, Chemicals chemicals)
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            Chemicals = chemicals;
            ShipmentType = shipmentType;

        }
    }

    public class Chemicals
    {
        [Required]
        public int Type_A { get; set; } = 0;

        [Required]
        public int Type_B { get; set; } = 0;

        [Required]
        public int Type_C { get; set; } = 0;
    }
}
