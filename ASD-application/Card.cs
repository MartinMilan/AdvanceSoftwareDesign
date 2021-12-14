using System;
namespace ASD_application
{
    public class Card : PaymentMethod
    {
        public Card()
        {
        }

        public bool Pay(double price)
        {
            return true;
        }
    }
}
