using System;
namespace Design_Principles.SRP.Solution
{
    public class FileLogger
    {
        public void Log(string message)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", message);
        }
    }

    class Customer
    {
        public FileLogger logger = new FileLogger();
        public void Add()
        {
            try
            {
                // Customer add implementation
            }
            catch(Exception ex)
            {
                logger.Log(ex.StackTrace.ToString());
            }
        }
    }
}