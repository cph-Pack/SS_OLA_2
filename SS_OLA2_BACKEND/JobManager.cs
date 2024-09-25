using System;
using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND
{
    public class JobManager
    {
        private static Random random = new Random();
        // add db connection
        public JobManager() { }

        // get shipment info about job type
        public Job CreateJob(JobType jobType) 
        {
            int randomWarehouseId = random.Next(1, 6);

            Job job = new Job() 
            {
                StorageLocation = new Warehouse(randomWarehouseId),
                Date = DateTime.Now,
                JobType = jobType,
                Status = "Pending"
            };

            // save in db
            return job; 
        }

    }
}
