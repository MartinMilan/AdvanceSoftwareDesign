using System;
namespace ASD_application
{
    public class ControllerBroker
    {
        private AccountHandler[] accountQueue;
        private MessageHandler[] messageQueue;
        private PaymentHandler[] paymentQueue;
        public ControllerBroker()
        {
        }

        public void DoAction(UserController userController) { }
    }
}
