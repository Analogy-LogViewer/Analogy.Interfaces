using System.Collections.Generic;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IAnalogyShareable
    {
        string OptionalTitle { get; set; }
        Task<bool> InitializeSender();
        void SendMessage(AnalogyLogMessage message, string source);
        void SendMessages(IEnumerable<AnalogyLogMessage> messages, string source);
        void SendMessages(byte[] messages, string source); 
        Task<bool> CleanupSender();
    }
}
