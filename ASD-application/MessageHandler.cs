using ASD_application;
using System;
public class MessageHandler{

    private EncryptionModule encryptionModule;

    public MessageHandler()
    {
        encryptionModule = new EncryptionModule();
    }

    public bool SendMessage(string message, string reciever_id, string sender_id)
    {
        string cipherText = encryptionModule.EncryptMessage(message, reciever_id);
        Message newMessage = CreateMessage(message, reciever_id, sender_id);

        Inbox senderInbox = new Inbox(sender_id);
        Inbox recieverInbox = new Inbox(reciever_id);

        senderInbox.RecieveMessage(newMessage);
        recieverInbox.RecieveMessage(newMessage);

        return true;
    }
    private Message CreateMessage(string message, string reciever_id, string sender_id)
    {
        return new TextMessage(message, sender_id, reciever_id);
    }
}

    


