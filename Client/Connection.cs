using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace Client;

public class Connection : IDisposable {
  private const string ConfigPath = "Client/server-config.json";
  public readonly IPEndPoint EndPoint;
  public readonly TcpClient Client;
  public readonly NetworkStream Stream;
  public readonly byte[] Buffer;

  public Connection()
  {
    ServerConfig config;
    using (var reader = new StreamReader(ConfigPath)) {
      config = JsonConvert.DeserializeObject<ServerConfig>(reader.ReadToEnd());
    }
    EndPoint = new IPEndPoint(IPAddress.Parse(config.IP), config.Port);
    Client = new TcpClient(EndPoint);
    Stream = Client.GetStream();
    Buffer = new byte[config.BufferSize];
  }

  public void Send(byte[] bytes)
  {
    Stream.Write(bytes);
  }
  
  public void Dispose()
  {
    Client.Dispose();
    Stream.Dispose();
    GC.SuppressFinalize(this);
  }
  private struct ServerConfig {
    public string IP;
    public int Port;
    public int BufferSize;
  }
}