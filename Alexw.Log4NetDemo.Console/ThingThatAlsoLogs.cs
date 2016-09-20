using System;
using log4net.Core;

namespace Alexw.Log4NetDemo.Console
{
    public class ThingThatAlsoLogs
    {
        private readonly ILogger _logger;

        public ThingThatAlsoLogs(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLogsForEveryLevel()
        {
            var name = GetType().Name;
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Alert, Message = "This is a Alert log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.All, Message = "This is a All log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Critical, Message = "This is a Critical log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Debug, Message = "This is a Debug log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Emergency, Message = "This is a Emergency log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Error, Message = "This is a Error log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Fatal, Message = "This is a Fatal log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Fine, Message = "This is a Fine log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Finer, Message = "This is a Finer log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Finest, Message = "This is a Finest log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Info, Message = "This is a Info log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Log4Net_Debug, Message = "This is a Log4Net_Debug log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Notice, Message = "This is a Notice log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Off, Message = "This is a Off log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Severe, Message = "This is a Severe log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Trace, Message = "This is a Trace log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Verbose, Message = "This is a Verbose log from " + name }));
            _logger.Log(new LoggingEvent(new LoggingEventData { TimeStamp = DateTime.UtcNow, Level = Level.Warn, Message = "This is a Warn log from " + name }));
        }
    }
}