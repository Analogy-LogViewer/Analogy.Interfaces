using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces.DataTypes
{
    public class FilterCriteria
    {
        public List<string> TextInclude { get; set; }
        public List<string> TextExclude { get; set; }
        public List<string> Sources { get; set; }
        public List<string> ExcludedSources { get; set; }
        public List<string> Modules { get; set; }
        public List<string> ExcludedModules { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public AnalogyLogLevel[] IncludeLevels { get; set; }
        public List<AnalogyColumnFilter> DynamicColumns { get; set; }

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
