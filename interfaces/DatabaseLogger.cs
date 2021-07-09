using System;

namespace interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Logger to database");
        }
    }
}