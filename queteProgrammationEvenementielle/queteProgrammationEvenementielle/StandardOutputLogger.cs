using System;

namespace queteProgrammationEvenementielle
{
	class StandardOutputLogger
    {
        public void Subscribe(Program program)
        {
            program.OnSendLog += OnLogSent;
        }
        public void OnLogSent(object sender, SendLogEventArgs args)
        {
            // When OnLogSent is called, it writes a log on the stream
            HandleLogSend(args.Message, args.DateTime);
        }
        public void HandleLogSend(String message, DateTime? dateTime = null)
        {
            if (dateTime == null)
            {
                dateTime = DateTime.Now;
            }
            String formattedMessage = String.Format("{0} - {1}", dateTime, message);

            Console.WriteLine(formattedMessage);

        }
    }
}
