using System.Collections;

namespace ASD_application
{
    public class Responder : Account
    {
        private ArrayList currentJobs;
        private Category chosenCategory;
        private Company associatedCompany;

        public Responder(Category chosenCategory, Company associatedCompany)
        {
            currentJobs = new ArrayList();
            this.chosenCategory = chosenCategory;
            this.associatedCompany = associatedCompany;
        }

        public void AddJob(Job job)
        {
            currentJobs.Add(job);
        }

        public Job GetJob(int index)
        {
            return (Job) currentJobs[index];
        }
    }



}