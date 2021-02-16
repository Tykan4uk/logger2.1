using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerModule2
{
    public class Actions
    {
        private Logger _logActions = Logger.Instance;
        public Result StartMethod()
        {
            _logActions.LogInfo($"Start method: {nameof(StartMethod)}");
            return new Result(true);
        }

        public Result SkipLogic()
        {
            _logActions.LogWarning($"Skipped logic in method: {nameof(SkipLogic)}");
            return new Result(true);
        }

        public Result BrokeLogic()
        {
            return new Result(false, "I broke a logic.");
        }
    }
}
