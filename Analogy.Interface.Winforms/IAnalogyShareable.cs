using Analogy.Interfaces.DataTypes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IAnalogyShareable
    {
        string OptionalTitle { get; set; }
        Task<bool> InitializeSender();
        void SendMessage(IAnalogyLogMessage message, string source);
        void SendMessages(List<IAnalogyLogMessage> messages, string source);
        void SendMessages(byte[] messages, string source);
        Task<bool> CleanupSender();
    }
}