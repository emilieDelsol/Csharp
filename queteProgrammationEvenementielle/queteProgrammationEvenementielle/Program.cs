using System;

namespace queteProgrammationEvenementielle
{
	class Program
    {
        public event EventHandler<SendLogEventArgs> OnSendLog;
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            var program = new Program();

            var logger = new StandardOutputLogger();
            var logger2 = new FileStreamOutputLogger();
            // Subscribe the logger to OnSendLog event

            logger.Subscribe(program);
            logger2.Subscribe(program);

            var eventArgs = new SendLogEventArgs("LogEvent published", DateTime.Now);

            // Dispatch OnSendLog subscribed loggers

            if (program.OnSendLog != null)
            {
                program.OnSendLog(program, eventArgs);
            }

        }
    }
}
