using System;

namespace EnterprisePatterns.Api.Common.Domain.Singleton
{
    public class LoggerThreadSafe3Singleton
    {
         private static readonly LoggerThreadSafe3Singleton instance = new LoggerThreadSafe3Singleton();  

        static LoggerThreadSafe3Singleton()  
        {  
        }  
        private LoggerThreadSafe3Singleton()  
        {  
        }  
        public static LoggerThreadSafe3Singleton Instance  
        {  
            get  
            {  
                return instance;  
            }  
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " - "  + DateTime.Now);
        }
    }
}
