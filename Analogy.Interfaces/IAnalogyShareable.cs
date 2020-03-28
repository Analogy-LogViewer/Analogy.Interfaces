using System.Collections.Generic;

namespace Analogy.Interfaces
{
    public interface IAnalogyShareable
    {
        void SendMessage(AnalogyLogMessage message, string source);
        void SendMessages(IEnumerable<AnalogyLogMessage> messages, string source);
        void SendMessages(byte[] messages, string source);
    }
}
