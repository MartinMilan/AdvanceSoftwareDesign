using System;

public sealed class Matcher
{
    private static Matcher instance = null;
    private static readonly object padlock = new object();

    Matcher()
    {

    }

    public static Matcher Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Matcher();
                }
                return instance;
            }
        }

    }
    public Job[] GetRequestorJobs(Requester requestor)
    {
        return new Job[0];
    }
    public Category GetResponderPref(Requester requestor)
    {
        return Category.Cooking;
    }
    public Job[] GetMatches(Category category)
    {
        Board board = new Board();
        Job[] jobs = board.GetJobList(category);
        foreach (Job job in jobs)
        {
            // Do operation
        }

        return jobs;
    }

    private Boolean IsMatch(Job job, Category category)
    {
        return true;
    }

    public Matcher GetInstance()
    {
        return instance;
    }
}
