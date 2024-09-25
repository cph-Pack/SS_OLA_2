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

        /*[Required]
        public string ChemicalType { get; set; }
        [Required]
        public int KilogramWeight { get; set; }*/
    }
    
    public class Chemicals
    {
        [Required]
        public int Type_A { get; set; } = 0;

        [Required]
        public int Type_B { get; set;} = 0;

        [Required]
        public int Type_C { get; set;} = 0;
}
