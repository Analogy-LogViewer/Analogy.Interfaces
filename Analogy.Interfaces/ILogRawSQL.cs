using System;

namespace Analogy.Interfaces
{
    public interface ILogRawSQL
    {
        bool ApplyRawSQLFilter(string filter);
        bool IsRawSQLModeEnabled();
        bool EnabledRawSQLMode();
        bool DisableRawSQLMode();
        public event EventHandler<string> OnRawSQLFilterChanged;
    }
}