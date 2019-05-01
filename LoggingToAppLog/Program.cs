using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggingToAppLog
{
    class Program
    {

        private static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            log4net.Config.XmlConfigurator.Configure();
            log4net.ThreadContext.Properties["EventID"] = 1022; // set to a known event id 

            log.Info("information");
            log.Warn("warning");
            log.Error("error");

            Console.ReadKey();

        }
    }
}
