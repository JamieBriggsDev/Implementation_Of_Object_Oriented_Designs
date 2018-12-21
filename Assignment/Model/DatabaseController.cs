using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DatabaseController
    {
        private List<Job> m_jobsList;
        
        bool GetAllJobs()
        {

            return true;
        }

        bool GetJobsSpecificMachine(int OID)
        {

            return true;
        }

        bool AssignStaffToJob(int staffID)
        {

            return true;
        }

        bool CloseJob(int JobID)
        {

            return true;
        }

        // TODO: BRANDON: Function to add a new job to the database (state always "Estimate Needed") on first creation

        // TODO: BRANDON: Function to edit a job entrys' state with a new string

        // TODO: BRANDON: Function to grab all staff names

        // TODO: BRANDON: Function to grab all currents jobs.

        // TODO: BRANDON: Function to grab all machines based on clientID

        // TODO: BRANDON: Function to add a machine to machine database

    }
}
