using System;

public class JobHistory
{
    private Job job;
    private DateTime startTime;
    private DateTime endTime;

    public JobHistory(Job job, DateTime startTime, DateTime endTime)
    {
        this.job = job;
        this.startTime = startTime;
        this.endTime = endTime;
    }
}