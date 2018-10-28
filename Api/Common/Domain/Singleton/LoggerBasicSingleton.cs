using System;

namespace EnterprisePatterns.Api.Common.Domain.Singleton
{
    public class LoggerBasicSingleton
    {
        private static LoggerBasicSingleton instance;

        private LoggerBasicSingleton()
        {
        }

        public static LoggerBasicSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new  LoggerBasicSingleton();
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " - "  + DateTime.Now);
        }
    }
}
