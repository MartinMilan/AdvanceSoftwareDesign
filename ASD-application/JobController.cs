using ASD_application;
using System;

public sealed class JobController
{
    private static JobController instance = null;
    private static readonly object padlock = new object();
    private JobManager jobManager;
    private JobTracker jobTracker;

    JobController()
    {
        jobManager = new JobManager();
        jobTracker = new JobTracker();
    }

    public static JobController Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new JobController();
                }
                return instance;
            }
        }
    }

    public void UpdateStatus()
    {

    }

    public void Notify()
    {

    }

    public Job CreateJob(string userId, int wage, DateTime date, string location, Category category)
    {
        return jobManager.CreateJob(userId, wage, date, location, category);
    }

    public void DeleteJob(Job job)
    {
        jobManager.DeleteJob(job);
    }

    public void ApplyJob(Responder applicant, string jobId)
    {
        jobManager.ApplyJob(applicant, jobId);
    }

    public JobHistory[] GetJobsInTimeframe(DateTime startTime, DateTime endTime, Requester user)
    {
        return jobTracker.GetJobsInTimeframe(startTime, endTime, user);
    }

    public Job[] GetMatches()
    {
        return new Job[0];
    }

    public void Update(Job job)
    {

    }
}
