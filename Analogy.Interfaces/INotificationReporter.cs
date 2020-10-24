using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface INotificationReporter
    {
        void RaiseNotification(IAnalogyNotification notification, bool showAsPopup);
    }
}
