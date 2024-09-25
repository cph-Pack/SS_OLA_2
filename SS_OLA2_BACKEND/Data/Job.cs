namespace SS_OLA2_BACKEND.Data
{
    public class Job
    {
        public int Id { get; set; }
        public Warehouse StorageLocation { get; set; }
        public DateTime Date { get; set; }
        public JobType JobType { get; set; }
        public string Status { get; set; }
    }
}
