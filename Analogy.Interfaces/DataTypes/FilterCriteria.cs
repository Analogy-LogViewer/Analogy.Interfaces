using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces.DataTypes
{
    public class FilterCriteria
    {
        private List<string> TextInclude { get; set; }
        private List<string> TextExclude { get; set; }
        private List<string> Sources { get; set; }
        private List<string> ExcludedSources { get; set; }
        private List<string> Modules { get; set; }
        private List<string> ExcludedModules { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private AnalogyLogLevel[] IncludeLevels { get; set; }
        private List<AnalogyColumnFilter> DynamicColumns { get; set; }

        public FilterCriteria(List<string> textInclude, List<string> textExclude, List<string> sources,
            List<string> excludedSources, List<string> modules, List<string> excludedModules, DateTime startTime,
            DateTime endTime, AnalogyLogLevel[] includeLevels, List<AnalogyColumnFilter> dynamicColumns)
        {
            TextInclude = textInclude;
            TextExclude = textExclude;
            Sources = sources;
            ExcludedSources = excludedSources;
            Modules = modules;
            ExcludedModules = excludedModules;
            StartTime = startTime;
            EndTime = endTime;
            IncludeLevels = includeLevels;
            DynamicColumns = dynamicColumns;
        }
    }
}
