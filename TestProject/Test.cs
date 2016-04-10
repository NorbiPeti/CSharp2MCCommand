using CSharp2MCCommand;
using MCCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Test : ICmdProgram
    {
        public void Start()
        {
            //Console.WriteLine("START");
            //MCCommand.Say("Hi");
            MCCommand.Particle("reddust", new Location(true, 0, 0, 0), -1, 0, 0, 1, 0, null);
        }

        public void Repeat()
        {
            Console.WriteLine("REPEAT");
        }
    }
}
