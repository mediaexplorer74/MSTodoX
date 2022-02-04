// 

using System;
using System.Diagnostics;
//using System.CommandLine;
//using System.CommandLine.Invocation;
using System.IO;
using System.Reflection;

namespace Todo.CLI.Handlers
{
    public class TodoCommandHandler
    {
        /*
        public static ICommandHandler Create()
        {
            return CommandHandler.Create<bool>((version) =>
            {
                if (version)
                {
                    PrintVersion();
                    return;
                }
            });
        }
        */

        private static void PrintVersion()
        {
            string entryAssembly = "123"; //Assembly.GetEntryAssembly();
            var entryAssemblyName = "somebody";//entryAssembly.GetName();
            var description = "456";//entryAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;
            //Debug.WriteLine($"{entryAssemblyName.Name} {entryAssemblyName.Version} - {description}");
        }
    }
}
