using System;

namespace Di
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger;

            string loggerType = "text";
            switch (loggerType)
            {
                case "DataBase":
                    logger = new DBlogger();
                    break;
                default:
                    logger = new TextLogger();
                    break;
            }
            LogManager manager = new LogManager(logger);
            try
            {
                throw new Exception("Exception throwed");
            }
            catch(Exception e)
            {
                manager.log(e.Message);
                Console.ReadKey();
            }
        }
        
        public interface ILogger
        {
            void log(string message);
        }

        class LogManager
        {
            private ILogger logger;
            public LogManager(ILogger logger)
            {
                this.logger = logger;
            }
            public void log(string message)
            {
                logger.log(message);
            }
        }
        class TextLogger : ILogger
        {
            public void log(string message)
            {
                Console.WriteLine("log of text : "+message);
            }
        }
        class DBlogger : ILogger
        {
            public void log(string message)
            {
                Console.WriteLine("log of text : " + message);
            }
        }
        
    }
}
