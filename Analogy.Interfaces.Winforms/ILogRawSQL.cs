using System;

namespace Analogy.Interfaces
{
    public interface ILogRawSQL
    {
        event EventHandler<string> OnRawSQLFilterChanged;
        bool ApplyRawSQLFilter(string filter);
        bool IsDisposed { get; }
        bool IsRawSQLModeEnabled { get; }
        bool EnableRawSQLMode();
        bool DisableRawSQLMode();
    }
}