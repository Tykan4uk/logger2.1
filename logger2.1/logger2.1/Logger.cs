using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerModule2
{
   public class Logger
{
        private static Logger instance;
        private static StringBuilder _log = new StringBuilder();

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public static void AddLog(CodeLog codelog, string msg)
        {
            _log.Append($"{DateTime.Now}: {codelog}: {msg}\n");
        }

        public static string GetLog()
        {
            return _log.ToString();
        }
}
}
