using System;
using System.Reactive.Linq;
using log4net;
using log4net.Core;
using log4net.Repository.Hierarchy;

// load log4net
[assembly: log4net.Config.XmlConfigurator]

namespace Alexw.Log4NetDemo.Console
{
    public class Program
    {
        private static readonly ILogger Logger = LogManager.GetLogger(string.Empty).Logger;

        public static void Main()
        {
            var thingThatLogs = new ThingThatLogs(Logger);
            var thingThatAlsoLogs = new ThingThatAlsoLogs(Logger);

            var startAfter = TimeSpan.Zero;
            var repeat = TimeSpan.FromSeconds(5);

            Observable.Timer(startAfter, repeat).Subscribe(x =>
            {
                // run every second
                thingThatLogs.WriteLogsForEveryLevel();
                thingThatAlsoLogs.WriteLogsForEveryLevel();
            });

            System.Console.ReadLine();
        }
    }
}
