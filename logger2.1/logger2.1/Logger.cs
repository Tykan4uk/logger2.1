using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerModule2
{
    public class Logger
    {
        private static readonly Logger _Instance = new Logger();
        private static readonly StringBuilder _Log = new StringBuilder();

        private Logger()
        {
        }

        public static Logger Current => _Instance;
        public static string Log
        {
            get => _Log.ToString();
            set
            {
                _Log.Append($"{DateTime.Now}: {value}{Environment.NewLine}");
                Console.WriteLine($"{DateTime.Now}: {value}");
            }
        }
    }
}
