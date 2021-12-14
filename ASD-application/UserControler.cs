using System;

public class UserController{
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

    public bool SendMessage(string[] reciever_id, string[] sender_id, string[] message){
        
        return true;
    }
    public void editAccountInfo(User user){

    }
    public void editPassword(string[] user_id, string[] password){

    }
    public void createAccount(string[] user_id, string[] address){

    }
    public bool handlePayment(string[] responderId, string[] recieverId, double price){

        return true;
    }
    public void setPaymentMethod(PaymentMethod paymentMethod){

    }
    public void markMessageReceived(){

    }
    public void markMessageRead(){

    }
    public void performMessage(){

    }
}
