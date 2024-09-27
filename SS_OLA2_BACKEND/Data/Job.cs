﻿namespace SS_OLA2_BACKEND.Data
{
    public class Job
    {

        public Guid JobId { get; private set; }
        public int StorageLocation { get; set; }
        public DateTime Date { get; set; }
        public JobType JobType { get; set; }
        public string Status { get; set; }

        public Job(int storageLocation, DateTime date, JobType jobType, string status)
        {
            // Unikt ID
            JobId = Guid.NewGuid();

            // Lagerlokationen (1 til 5)
            if (storageLocation < 1 || storageLocation > 5)
            {
                throw new ArgumentException("Storage location must be between 1 and 5.");
            }
            StorageLocation = storageLocation;

            Date = date;
            JobType = jobType;
            Status = status;
        }
    }
}
