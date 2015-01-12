using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticLoggingConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize log4net configuration
            log4net.Config.XmlConfigurator.Configure();
            // initialize the logger
            var logger = log4net.LogManager.GetLogger("SemanticLoggingConsoleSample");
            // send a log event
            logger.Fatal(
                new
                {
                    Message = "Hi from my first project.",
                    Category = "ExecutionLogs"
                });

        }
    }
}
