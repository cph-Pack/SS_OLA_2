using System.ComponentModel.DataAnnotations;

namespace SS_OLA2_FRONTEND.Data
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
        public string ChemicalType { get; set; }
        [Required]
        public int KilogramWeight { get; set; }
    }
}
