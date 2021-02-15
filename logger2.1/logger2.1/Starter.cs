using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerModule2
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();
            var result = new Result();
            for (var i = 0; i < 100; i++)
            {
                var rnd = (ActionsMethod)new Random().Next(0, 3);
                switch (rnd)
                {
                    case ActionsMethod.StartMethod: result = actions.StartMethod(); break;
                    case ActionsMethod.SkipLogic: result = actions.SkipLogic(); break;
                    case ActionsMethod.BrokeLogic: result = actions.BrokeLogic(); break;
                }

                if (!result.Status)
                {
                    Logger.AddLog(CodeLog.Error, $"Action failed by a reason: {result.Message}");
                }
            }

            File.WriteAllText("log.txt", Logger.GetLog());
        }
    }
}