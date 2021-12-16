using System;
namespace ASD_application
{
    public class TextMessage : Message
    {
        private string senderID;
        private string recieverID;
        private string messageID;
        private DateTime sendDate;
        private String text;

        public TextMessage(string message, string senderID, string recieverID)
        {
            text = message;
            this.senderID = senderID;
            this.recieverID = recieverID;

        }

        public void MarkRead()
        {
            throw new NotImplementedException();
        }

        public void MarkRecieved()
        {
            throw new NotImplementedException();
        }

        public void PerformAction()
        {
            throw new NotImplementedException();
        }

        public void ShowContent()
        {
            throw new NotImplementedException();
        }
    }
}
