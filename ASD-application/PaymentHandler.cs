using System;
namespace ASD_application
{
    public class PaymentHandler
    {
        private PaymentMethod paymentStrategy;
        private Job job;

        public PaymentHandler()
        {

        }

        private int GetPrice(Job job) {
            return job.GetWage();
        }

        public void SetPaymentMethod(PaymentMethod paymentMethod) {

            paymentStrategy = paymentMethod;
        }

        public Boolean HandlePayment(String responderID, String recieverID, Double Price) {
            return true;
            
        }
    }
}
