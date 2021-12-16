using System;
using System.Collections;

namespace ASD_application
{
    public class Inbox
    {
        private MessageDBAcess messageDBAcess;
        private ArrayList chatRecord;
        private Message messageStrategy;
        private string owner_id;

        public Inbox(string user_id)
        {
            owner_id = user_id;
            chatRecord = new ArrayList();
        }
        public Boolean RecieveMessage(Message message)
        {
            chatRecord.Add(message);
            return true;
        }
    }
}
