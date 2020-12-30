using System;

namespace Solid_inversion_dependency
{
	class Program
	{
		static void Main(string[] args)
		{

                Terminal terminal = new Terminal();

                while (!terminal.Exited)

                {

                    Command command = terminal.PromptCommand();

                    terminal.ExecuteCommand(command);

                }

        }
	}
}
