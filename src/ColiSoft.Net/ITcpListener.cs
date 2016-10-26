using System.Threading;
using System.Threading.Tasks;

namespace ColiSoft.Net
{
    public interface ITcpListener
    { 
        Task<ITcpClient> AcceptTcpClientAsync(CancellationToken ct = default(CancellationToken), int timeout = 0);
        void Start();
        void Stop();
    }
}
