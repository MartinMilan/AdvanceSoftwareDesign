using System;
namespace ASD_application
{
    public class Indbox
    {
        private MessageDBAcess messageDBAcess;
        private Message chatRecord;
        private Message messageStrategy;
        public Indbox()
        {
        }
        public Boolean RecievedMessage(Message message)
        {

            return true;
        }
    }
}
