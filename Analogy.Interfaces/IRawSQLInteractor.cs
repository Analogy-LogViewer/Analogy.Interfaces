using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IRawSQLInteractor
    {
        /// <summary>
        /// object that enables the User Control to change the RAW SQL filter (normally LogMessage User Control)
        /// </summary>
        /// <param name="rawSQLInteractor"></param>
        void SetRawSQLHandler(ILogRawSQL rawSQLHandler);
    }
}
