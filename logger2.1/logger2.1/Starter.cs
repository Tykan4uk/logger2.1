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
        private readonly int _minRandomAction = 0;
        private readonly int _maxRandomAction = 3;
        private readonly Random _random = new Random();
        private readonly Actions _actions = new Actions();
        private Result _result = new Result();
        public void Run()
        {
            var randomAction = 0;
            for (var i = 0; i < 100; i++)
            {
                randomAction = _random.Next(_minRandomAction, _maxRandomAction);
                switch (randomAction)
                {
                    case 0:
                        _result = _actions.StartMethod();
                        break;
                    case 1:
                        _result = _actions.SkipLogic();
                        break;
                    case 2:
                        _result = _actions.BrokeLogic();
                        break;
                }

                if (!_result.Status)
                {
                    Logger.Log = $"{CodeLog.Error}: Action failed by a reason: {_result.Message}";
                }
            }

            File.WriteAllText("log.txt", Logger.Log);
        }
    }
}