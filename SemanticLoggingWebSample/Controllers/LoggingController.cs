using SemanticLoggingWebSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SemanticLoggingWebSample.Controllers
{
    public class LoggingController : ApiController
    {
        private log4net.ILog _logger;
        
        public LoggingController()
        {
            // initialize log4net configuration
            log4net.Config.XmlConfigurator.Configure();
            // initialize the logger
            _logger = log4net.LogManager.GetLogger("SemanticLoggingWebSample");
        }

        [HttpGet]
        public string Get()
        {
            return "Working!";
        }

        [HttpPost]
        public void Log([FromBody]MessageDto message)
        {
            switch (message.Level)
            {
                case "Debug":
                    _logger.Debug(new
                    {
                        Message = message.Message,
                        Category = "ExecutionLogs"
                    });
                    break;
                case "Fatal":
                    _logger.Fatal(new
                    {
                        Message = message.Message,
                        Category = "ExecutionLogs"
                    });
                    break;
                default:
                    _logger.Info(new
                    {
                        Message = message.Message,
                        Category = "ExecutionLogs"
                    });
                    break;
            }
        }
    }
}
