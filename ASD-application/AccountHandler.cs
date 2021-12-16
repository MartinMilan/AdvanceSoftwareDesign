using ASD_application;
using System;
public class AccountHandler{



    private UserDBAccess userDBAccess;

    public AccountHandler()
    {
        userDBAccess = new UserDBAccess();
    }

    public void editAccountInfo(Account user){

    }
    public void editPassword(string[] user_id, string[] password){

    }
    public void createAccount(string[] user_id, string[] address, string[] phone_number){
        userDBAccess.storeUserAccount(new Account());
    }
}