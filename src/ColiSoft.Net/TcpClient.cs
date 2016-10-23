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
    }
}
