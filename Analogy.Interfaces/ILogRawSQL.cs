using System;

namespace Analogy.Interfaces
{
    public interface ILogRawSQL
    {
        bool ApplyRawSQLFilter(string filter);
        public event EventHandler<string> OnSetRawSQLFilter;
    }
}