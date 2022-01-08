using ASD_application;
using System;

public class JobManager
{
    private IJobObserver[] listeners;

    public JobManager()
    {
        listeners = new IJobObserver[5];
        listeners[0] = new JobTracker();
        listeners[1] = new Board();
    }

    public void Subscribe(IJobObserver observer) { }
    public void Unsubscribe(IJobObserver observer) {}
    public void Notify(Job job, Category category) {}
    public Job CreateJob(string userId, int wage, DateTime deadline, string location, Category category) {
        return new Job();
        
    }

    public void DeleteJob(Job job)
    {

    }

    public void ApplyJob(Responder applicant, string jobId)
    {
        Requester requester = new Requester();
        Job job = new Job();
        bool response = requester.ApplyJob(applicant, job);

        if(response)
        {
            job.UpdateStatus(Status.Accepted);
            update(job);
        }
    }

    public void GetMatches(string responderId)
    {
        Responder responder = new Responder(Category.Teaching, null);
        responder.GetMatches();
    }

    internal void update(Job job)
    {
        foreach (var listener in listeners)
        {
            listener.Update(job, Category.Cooking);
        }
    }
}