using System;
namespace ASD_application
{
    public interface Message
    {
        void MarkRecieved();
        void MarkRead();
        void PerformAction();
        void ShowContent();
    }
}
