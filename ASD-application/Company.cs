namespace ASD_application
{
    public class Company
    {
        private int companyCut;
        private Category companyCategory;
        private Responder[] workers;
        
        public Company()
        {

        }

        public Responder[] GetAvailableWorkers()
        {
            return new Responder[0];
        }


        public Status CheckResponderStatus(Responder responder, Job currentJob)
        {
            return currentJob.GetStatus();
        }

        public int CalculateRespondersCut(Responder[] workers)
        {
            return 25;
        }

    }
}