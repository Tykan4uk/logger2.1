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

        public static Logger Current => _instance;
        public string Instance
        {
            get => _log.ToString();
            set
            {
                var tempString = $"{DateTime.Now}: {value}";
                _log.AppendLine(tempString);
                Console.WriteLine(tempString);
            }
        }
    }
}
