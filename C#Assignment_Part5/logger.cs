using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment_Part5
{

    public class Loggerr
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Loggerr));

        static Loggerr()
        {
            XmlConfigurator.Configure();
        }

        public static void LogError(string message, Exception ex)
        {
            log.Error(message, ex);
        }
    }
}