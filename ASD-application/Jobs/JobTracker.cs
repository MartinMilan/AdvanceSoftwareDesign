using System;

public class JobTracker : IJobObserver
{
    private JobDBAccess jobDBAccess;

    public JobTracker()
    {
        jobDBAccess = new JobDBAccess();
    }
    public JobHistory[] GetJobsInTimeframe(DateTime startTime, DateTime endTime, Requester user)
    {
        return jobDBAccess.retrieveJobs(startTime, endTime, user);
    }

    public void Update(Job job, Category category)
    {
        throw new NotImplementedException();
    }
}