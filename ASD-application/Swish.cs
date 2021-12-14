using System;
namespace ASD_application
{
    public class Swish : PaymentMethod
    {
        public Swish()
        {
        }

        public Boolean Pay(Double price) {
            return true;
        }
    }
}
