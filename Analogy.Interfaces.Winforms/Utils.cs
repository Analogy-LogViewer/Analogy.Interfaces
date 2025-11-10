using System;
using System.Collections.Generic;
using System.Linq;

namespace Analogy.Interfaces
{
    public static class Utils
    {
        public static IEnumerable<AnalogyLogLevel> AllLogLevels { get; } = Enum.GetValues(typeof(AnalogyLogLevel)).Cast<AnalogyLogLevel>();
    }
}