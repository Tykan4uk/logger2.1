using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerModule2
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _log = new StringBuilder();

        private Logger()
        {
        }

        public static Logger Instance => _instance;

        public void Log(CodeLog type, string message)
        {
            var tempString = $"{DateTime.Now}: {type}: {message}";
            _log.AppendLine(tempString);
            Console.WriteLine(tempString);
        }

        public void LogError(string message)
        {
            Log(CodeLog.Error, message);
        }

        public void LogInfo(string message)
        {
            Log(CodeLog.Info, message);
        }

        public void LogWarning(string message)
        {
            Log(CodeLog.Warning, message);
        }

        public string ReturnLog()
        {
            return _log.ToString();
        }
    }
}
