public interface IPlugin
{
    void Execute();
}
public class MyPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("MyPlugin executed!");
    }
}
using System;
using System.Reflection;

public class PluginLoader
{
    public void LoadAndExecutePlugin(string assemblyPath)
    {
        Assembly assembly = Assembly.LoadFrom(assemblyPath);
        foreach (var type in assembly.GetTypes())
        {
            if (typeof(IPlugin).IsAssignableFrom(type))
            {
                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                plugin.Execute();
            }
        }
    }
}