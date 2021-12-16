using System;

public class Job
{
    private int wage;
    private DateTime deadline;
    private string location;
    private Requester requester;
    private Status jobCurrentStatus;
    private string[] jobConstraints;
    private string job_id;

    public Job()
    {

    }
    public Job(int wage, DateTime deadline, string location, Requester requester, string[] jobConstraints)
    {
        this.wage = wage;
        this.deadline = deadline;
        this.location = location;
        this.requester = requester;
        this.jobConstraints = jobConstraints;
    }

    public int GetWage()
    {
        return wage;
    }

    public Status GetStatus()
    {
        return jobCurrentStatus;
    }

    public void UpdateStatus(Status status) { }
    public void PostJob() 
    {
            
    }
}