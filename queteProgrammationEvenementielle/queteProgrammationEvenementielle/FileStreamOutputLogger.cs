using System;
using System.IO;
using System.Text;

namespace queteProgrammationEvenementielle
{
	class FileStreamOutputLogger
    {

            public void Subscribe(Program program)
            {
                program.OnSendLog += OnLogSent;
            }

            private void OnLogSent(object sender, SendLogEventArgs args)
            {
                HandleLogSend(args.Message, args.DateTime);
           
                // When OnLogSent is called, it writes a log on the stream
            }

            public void HandleLogSend(object message, object dateTime)
            {
                if (dateTime == null)
                {
                    dateTime = DateTime.Now;
                }
                String formattedMessage = String.Format("{0} - {1}", dateTime, message);
                string path = @"D:\Documents\wild\workSpace\quetesCsharp\queteProgrammationEvenementielle\queteEvent.txt";
                using (FileStream fs = File.Create(path))
                {
                    AddText(fs, formattedMessage);
                }
        }

		private void AddText(FileStream fs, string value)
		{
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
	}
}
