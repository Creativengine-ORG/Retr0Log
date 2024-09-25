using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retr0Log
{
    public class Logger
    {
        public string name;
        public LogSettings settings;

        public Logger(string name, LogSettings settings)
        {
            this.name = name;
            this.settings = settings;
        }

        public void Log(string message, LogLevel level)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");

            string finTime = settings.showTime ? "[" + time + "] " : "";
            string finType = settings.showMessageLevel ? "[" + level.ToString().ToUpper() + "] " : "";
            string finName = settings.showName ? name + ": " : "";

            switch (level)
            {
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Warn:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevel.Fatal:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    break;
            }

            if (level == LogLevel.Fatal)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine($"{finTime}{finType}{finName}{message}");
        }
    }

    public struct LogSettings
    {
        public bool showTime;
        public bool showName;
        public bool showMessageLevel;

        public LogSettings(bool showTime, bool showName, bool showMessageLevel)
        {
            this.showTime = showTime;
            this.showName = showName;
            this.showMessageLevel = showMessageLevel;
        }
    }

    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error,
        Fatal,
        Success
    }
}
