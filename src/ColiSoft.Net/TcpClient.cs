using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ColiSoft.Net
{
    public class TcpClient : ITcpClient
    {
        private System.Net.Sockets.TcpClient _TcpClient;
        public TcpClient(System.Net.Sockets.TcpClient tcpClient)
        {
            _TcpClient = tcpClient;
        }
        public async Task ConnectAsync(System.Net.IPAddress ipAddr, int port, CancellationToken ct = default(CancellationToken), int timeout = 0)
        {
            await _TcpClient.ConnectAsync(ipAddr, port).WithCancellation(ct).WithTimeout(timeout);
        }
        public async Task ConnectAsync(string host, int port, CancellationToken ct = default(CancellationToken), int timeout = 0)
        {
            await _TcpClient.ConnectAsync(host, port).WithCancellation(ct).WithTimeout(timeout);
        }
        public Stream GetStream()
        {
            return _TcpClient.GetStream();
        }
    }
}
