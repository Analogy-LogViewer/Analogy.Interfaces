using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IAnalogyOnDemandPlottingManager
    {
        public void ShowPlot(Guid id,AnalogyOnDemandPlottingStartupType startupType);
        public void ForceClose(Guid id);
        public void ForceClearData(Guid id, string seriesToClear);
    }
}
