using System;
namespace ASD_application
{
    public class Paypal : PaymentMethod
    {
        public Paypal()
        {
        }

        public bool Pay(double price)
        {
            return true;
        }
    }
}
