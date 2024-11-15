public class DataTransfer : MarshalByRefObject
{
    public string TransferData(string data)
    {
        return $"Received: {data}";
    }
}
public class Server
{
    public static void Main()
    {
        RemotingConfiguration.Configure("Server.config", false);
        Console.WriteLine("Server is running...");
        Console.ReadLine();
    }
}
<configuration>
  <system.runtime.remoting>
    <services>
      <service name="DataTransfer" type="YourNamespace.DataTransfer, YourAssembly" />
    </services>
  </system.runtime.remoting>
</configuration>
public class Client
{
    public static void Main()
    {
        DataTransfer remoteObject = (DataTransfer)Activator.GetObject(
            typeof(DataTransfer), "tcp://localhost:8080/DataTransfer");
        Console.WriteLine(remoteObject.TransferData("Hello from client!"));
    }
}