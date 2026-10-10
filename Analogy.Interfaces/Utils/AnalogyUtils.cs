using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Analogy.Interfaces.Utils
{
    public static class AnalogyUtils
    {
        public static IEnumerable<AnalogyLogLevel> AllLogLevels { get; } = GetLevels();

        private static AnalogyLogLevel[] GetLevels()
        {
#if NET
            return Enum.GetValues<AnalogyLogLevel>();
#else
            return [.. Enum.GetValues(typeof(AnalogyLogLevel)).Cast<AnalogyLogLevel>()];
#endif
        }
    }
}