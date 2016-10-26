using System.IO;
using System.Threading;
using System.Threading.Tasks;

public interface ITcpClient 
{
    Task ConnectAsync(System.Net.IPAddress ipAddr, int port, CancellationToken ct = default(CancellationToken), int timeout = 0);
    Task ConnectAsync(string host, int port, CancellationToken ct = default(CancellationToken), int timeout = 0);
    Stream GetStream();     
}
