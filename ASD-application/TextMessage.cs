﻿using System;
namespace ASD_application
{
    public class TextMessage : Message
    {
        private int senderID;
        private int recieverID;
        private int messageID;
        private DateTime sendDate;
        private String text;

        public TextMessage()
        {
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
