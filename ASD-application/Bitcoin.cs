using System;
namespace ASD_application
{
    public class Bitcoin : PaymentMethod
    {
        public Bitcoin()
        {
        }

        public bool Pay(double price)
        {
            return true;
        }
    }
}
