using System.Threading.Tasks;
using Node.Messages;

namespace Node.Connections
{
    internal interface IConnection
    {
        IAddress RemoteAddress { get; }
        
        IAddress LocalAddress { get; }

        SendResult Send(IMessage message);

        SendResult Push(IMessage message);

        IMessage Receive();

        void Tick(bool canRead);

        void Close();

        ConnectionState State { get; }
    }
}