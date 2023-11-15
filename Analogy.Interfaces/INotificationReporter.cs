namespace Analogy.Interfaces
{
    public interface INotificationReporter
    {
        void RaiseNotification(IAnalogyNotification notification, bool showAsPopup);
    }
}