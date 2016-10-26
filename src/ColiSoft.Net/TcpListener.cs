using System.Threading;
using System.Threading.Tasks;

namespace ColiSoft.Net
{
    public class TcpListener : ITcpListener
    {
        private System.Net.Sockets.TcpListener _TcpListener;
        public TcpListener(System.Net.Sockets.TcpListener tcpListener)
        {
            _TcpListener = tcpListener;
        }
        public async Task<ITcpClient> AcceptTcpClientAsync(CancellationToken ct = default(CancellationToken), int timeout = 0)
        {
            return new TcpClient(await _TcpListener.AcceptTcpClientAsync().WithCancellation(ct));           
        }
    }
}
