using Retr0Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Logger
            Logger myLog = new Logger("My Log", new LogSettings(true, true, true));

            // Print Messages
            myLog.Log("Hello World! This is Debug Message!", LogLevel.Debug);
            myLog.Log("Hello World! This is Info Message!", LogLevel.Info);
            myLog.Log("Hello World! This is Warning Message!", LogLevel.Warn);
            myLog.Log("Hello World! This is Error Message!", LogLevel.Error);
            myLog.Log("Hello World! This is Fatal Message!", LogLevel.Fatal);
            myLog.Log("Hello World! This is Success Message!", LogLevel.Success);

            // Wait to see the result
            Console.ReadKey();
        }
    }
}
