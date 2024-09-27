using System;
using SS_OLA2_BACKEND.Data;

namespace SS_OLA2_BACKEND
{
    public class JobManager
    {
        private DBManager _dBManager;
        private static Random random = new Random();
        
        public JobManager(DBManager dBManager) 
        { 
            _dBManager = dBManager;
        }

        // get shipment info about job type
        public Job CreateJob(JobType jobType) 
        {
            int storageLocation = random.Next(1, 6);
            DateTime date = DateTime.Now;
            string status = "Pending";

            Job job = new Job(storageLocation, date, jobType, status);

            job = _dBManager.SaveJob(job);
            return job; 
        }

    }
}
