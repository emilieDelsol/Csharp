using System;

namespace queteProgrammationEvenementielle
{
	class SendLogEventArgs : EventArgs
    {
        public String Message;
        public DateTime DateTime;
        public SendLogEventArgs(String message, DateTime dateTime)
        {
            Message = message;

            DateTime = dateTime;
        }

    }
}
