using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    /// <summary>
    /// interface to allow message modification before presenting in the UI 
    /// </summary>
    internal interface IAnalogyLogMessageInteractor
    {
        Task<IAnalogyLogMessage> HandleMessage(IAnalogyLogMessage message);
    }
}