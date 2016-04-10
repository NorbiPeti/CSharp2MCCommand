using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCommands
{
    public class Error : InvalidOperationException
    {
        public Error() : base("Use CSharp2MCCommand.exe to convert this application.")
        {
        }
    }
}
