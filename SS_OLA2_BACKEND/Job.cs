namespace SS_OLA2_BACKEND
{
    public class Job
    {
        // Unikt ID for jobbet
        public Guid JobId { get; private set; }

        // Lagerlokation (1-5)
        public int StorageLocation { get; set; }

        // Dato for jobbet
        public DateTime JobDate { get; set; }

        // Jobtype (levering eller afhentning)
        public string ShipmentType { get; set; } // Delivery eller Collection

        // Status på jobbet
        public string Status { get; set; } // F.eks. Pending, Completed, Cancelled

        // Constructor til initialisering af job
        public Job(int storageLocation, DateTime jobDate, string jobType, string status)
        {
            // Unikt ID
            JobId = Guid.NewGuid();

            // Lagerlokationen (1 til 5)
            if (storageLocation < 1 || storageLocation > 5)
            {
                throw new ArgumentException("Storage location must be between 1 and 5.");
            }
            StorageLocation = storageLocation;

            JobDate = jobDate;

            // Jobtypen (levering eller afhentning)
            if (jobType != "Delivery" && jobType != "Collection")
            {
                throw new ArgumentException("Job type must be 'Delivery' or 'Collection'.");
            }
            ShipmentType = jobType;

            // Sætter status for jobbet
            Status = status;
        }
    }
}
