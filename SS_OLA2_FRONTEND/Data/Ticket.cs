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
        public Chemicals chemicals { get; set; }
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
