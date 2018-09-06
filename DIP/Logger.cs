namespace dip
{
    using System;
    using Microsoft.AspNetCore.Http;
    public interface ILogger
    {
        void Log(HttpRequest request);
    }

    public class Logger : ILogger
    {
        void ILogger.Log(HttpRequest request)
        {
            // logger implementataion
        }
    }
}