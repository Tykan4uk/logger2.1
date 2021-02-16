using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerModule2
{
    public class Actions
    {
        public Result StartMethod()
        {
            Logger.Log = $"{CodeLog.Info}: Start method: {nameof(StartMethod)}";
            return new Result(true);
        }

        public Result SkipLogic()
        {
            Logger.Log = $"{CodeLog.Warning}: Skipped logic in method: {nameof(SkipLogic)}";
            return new Result(true);
        }

        public Result BrokeLogic()
        {
            return new Result(false, "I broke a logic.");
        }
    }
}
