using ASD_application;
using System;

public class UserController{

    private static UserController instance = null;
    private static readonly object padlock = new object();

    private AccountHandler accountHandler;
    private MessageHandler messageHandler;
    private PaymentHandler paymentHandler;

    public static UserController Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new UserController();
                }
                return instance;
            }
        }
    }

    public UserController()
    {
        accountHandler = new AccountHandler();
        messageHandler = new MessageHandler();
        paymentHandler = new PaymentHandler();
    }

    public bool SendMessage(string reciever_id, string sender_id, string message)
    {
        return messageHandler.SendMessage(message, reciever_id, sender_id);
    }
    public void editAccountInfo(Account user){
        
    }
    public void editPassword(string user_id, string password){

    }
    public void createAccount(string user_id, string address){

    }
    public bool handlePayment(string responderId, string recieverId, double price){
        return paymentHandler.HandlePayment(responderId, recieverId, price);
    }
    public void setPaymentMethod(PaymentMethod paymentMethod){
        paymentHandler.SetPaymentMethod(paymentMethod);
    }
    public void markMessageReceived(){

    }
    public void markMessageRead(){

    }
    public void performMessage(){

    }
}
