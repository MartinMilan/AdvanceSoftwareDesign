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
<<<<<<< HEAD
            return 1;
=======
            return job.GetWage();
>>>>>>> dad400290983e145cb70e36370e207759b051f11

        }

        public void SetPaymentMethod(PaymentMethod paymentMethod) {

            paymentStrategy = paymentMethod;
        }

        public Boolean HandlePayment(String responderID, String recieverID, Double Price) {
            return true;
            
        }
    }
}
