using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces.DataTypes
{
    public class FilterCriteria
    {
        public IEnumerable<string> IncludeText { get; set; }
        public IEnumerable<string> ExcludeText { get; set; }
        public IEnumerable<string> IncludeSources { get; set; }
        public IEnumerable<string> ExcludeSources { get; set; }
        public IEnumerable<string> IncludeModules { get; set; }
        public IEnumerable<string> ExcludeModules { get; set; }
        public IEnumerable<AnalogyLogLevel> IncludeLevels { get; set; }
        public IEnumerable<AnalogyLogLevel> ExcludeLevels { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public IEnumerable<AnalogyColumnFilter> DynamicColumns { get; set; }

        public FilterCriteria(List<string>? includeText = null, List<string>? excludeText = null, List<string>? includeSources = null,
            List<string>? excludeSources = null, List<string>? includeModules = null, List<string>? excludeModules = null, DateTime? startTime = null,
            DateTime? endTime = null, List<AnalogyLogLevel>? includeLevels = null, List<AnalogyLogLevel>? excludeLevels = null, List<AnalogyColumnFilter>? dynamicColumns = null)
        {
            IncludeText = includeText ?? Enumerable.Empty<string>();
            ExcludeText = excludeText ?? Enumerable.Empty<string>();
            IncludeSources = includeSources ?? Enumerable.Empty<string>();
            ExcludeSources = excludeSources ?? Enumerable.Empty<string>();
            IncludeModules = includeModules ?? Enumerable.Empty<string>();
            ExcludeModules = excludeModules ?? Enumerable.Empty<string>();
            StartTime = startTime;
            EndTime = endTime;
            IncludeLevels = includeLevels ?? Enumerable.Empty<AnalogyLogLevel>();
            ExcludeLevels = excludeLevels ?? Enumerable.Empty<AnalogyLogLevel>();
            DynamicColumns = dynamicColumns ?? Enumerable.Empty<AnalogyColumnFilter>();
        }


    }
}
