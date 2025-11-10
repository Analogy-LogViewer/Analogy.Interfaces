namespace Analogy.Interfaces.Winforms
{
    public interface INotificationReporterWinforms : INotificationReporter
    {
        void RaiseNotification(IAnalogyNotificationWinforms notification, bool showAsPopup);
    }
}