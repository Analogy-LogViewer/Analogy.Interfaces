namespace Analogy.Interfaces
{
    public interface INotificationReporter
    {
        void RaiseNotification(Interface.Winforms.IAnalogyNotificationWinforms notification, bool showAsPopup);
    }
}