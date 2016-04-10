using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2MCCommand
{
    public static class Converter
    {
        public static void ConvertToCommands(string filename)
        {
            var asm = AssemblyDefinition.ReadAssembly(filename);
            foreach (var type in asm.MainModule.GetTypes().Where(t => typeof(ICmdProgram).IsAssignableFrom(Type.GetType(t.FullName + ", " + t.Module.Assembly.FullName))))
            {
                var td = asm.MainModule.Import(type).Resolve();
                var start = td.Methods.First(m => m.Name == "Start");
                var repeat = td.Methods.First(m => m.Name == "Repeat");
                foreach(var i in start.Body.Instructions)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
