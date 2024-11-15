[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class LogMethodAttribute : Attribute
{
    public string LogMessage { get; }
    public LogMethodAttribute(string logMessage)
    {
        LogMessage = logMessage;
    }
}
public class SampleService
{
    [LogMethod("Start processing request")]
    public void ProcessRequest()
    {
        // Business logic here
    }
}
using System;
using System.Reflection;

public class Logger
{
    public static void LogMethodAttributes(Type type)
    {
        foreach (var method in type.GetMethods())
        {
            var attribute = method.GetCustomAttribute<LogMethodAttribute>();
            if (attribute != null)
            {
                Console.WriteLine($"Log Message for {method.Name}: {attribute.LogMessage}");
            }
        }
    }
}
Logger.LogMethodAttributes(typeof(SampleService));