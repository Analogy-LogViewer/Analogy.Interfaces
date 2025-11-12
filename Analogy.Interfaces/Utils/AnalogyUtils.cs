using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analogy.Interfaces.Utils
{
    public static class AnalogyUtils
    {
        public static IEnumerable<AnalogyLogLevel> AllLogLevels { get; } = Enum.GetValues(typeof(AnalogyLogLevel)).Cast<AnalogyLogLevel>();
    }
}