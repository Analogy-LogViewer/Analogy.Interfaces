namespace Analogy.Interfaces.WinForms
{
    public interface INotificationReporterWinForms : INotificationReporter
    {
        void RaiseNotification(IAnalogyNotificationWinForms notification, bool showAsPopup);
    }
}