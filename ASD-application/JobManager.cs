using ASD_application;
using System;

public class JobManager
{
    private IJobObserver[] listeners;

    public JobManager()
    {

    }

    public void Subscribe(IJobObserver observer) { }
    public void Unsubscribe(IJobObserver observer) { }
    public void Notify(Job job, Category category) {}
    public Job CreateJob(string userId, int wage, DateTime deadline, string location, Category category) {
        return new Job();
    }

    public void DeleteJob(Job job)
    {

    }

    public void ApplyJob(Responder applicant, string jobId)
    {

    }

    public void GetMatches(string responderId)
    {
        // Call Matcher
    }



}