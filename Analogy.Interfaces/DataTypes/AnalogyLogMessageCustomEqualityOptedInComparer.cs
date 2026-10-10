using System;
using System.Collections.Generic;
using System.Linq;

namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyLogMessageCustomEqualityOptedInComparer : IEqualityComparer<IAnalogyLogMessage>
    {
        public bool CompareDate { get; set; }
        public bool CompareId { get; set; }
        public bool CompareText { get; set; }
        public bool CompareSource { get; set; }
        public bool CompareModule { get; set; }
        public bool CompareMethodName { get; set; }
        public bool CompareFileName { get; set; }
        public bool CompareUser { get; set; }
        public bool CompareLineNumber { get; set; }
        public bool CompareProcessId { get; set; }
        public bool CompareThread { get; set; }
        public bool CompareLevel { get; set; }
        public bool CompareClass { get; set; }
        public bool CompareParameters { get; set; }

        public AnalogyLogMessageCustomEqualityOptedInComparer()
        {
        }

        public AnalogyLogMessageCustomEqualityOptedInComparer(bool compareDate, bool compareId, bool compareText,
            bool compareSource, bool compareModule, bool compareMethodName, bool compareFileName,
            bool compareUser, bool compareLineNumber, bool compareProcessId, bool compareThread, bool compareLevel,
            bool compareClass, bool compareParameters)
        {
            CompareDate = compareDate;
            CompareId = compareId;
            CompareText = compareText;
            CompareSource = compareSource;
            CompareModule = compareModule;
            CompareMethodName = compareMethodName;
            CompareFileName = compareFileName;
            CompareUser = compareUser;
            CompareLineNumber = compareLineNumber;
            CompareProcessId = compareProcessId;
            CompareThread = compareThread;
            CompareLevel = compareLevel;
            CompareClass = compareClass;
            CompareParameters = compareParameters;
        }

        public bool Equals(IAnalogyLogMessage? x, IAnalogyLogMessage? y)
        {
            if (x is null || y is null)
            {
                return false;
            }

            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (CompareDate && !x.Date.Equals(y.Date))
            {
                return false;
            }

            if (CompareId && !x.Id.Equals(y.Id))
            {
                return false;
            }

            if ((CompareText && ((x.Text is not null && y.Text is null) || (x.Text is null && y.Text is not null))) ||
                ((x.Text is not null && y.Text is not null) && !x.Text.Equals(y.Text)))
            {
                return false;
            }

            if (CompareSource && !string.Equals(x.Source, y.Source, StringComparison.Ordinal))
            {
                return false;
            }

            if (CompareModule && !string.Equals(x.Module, y.Module, StringComparison.Ordinal))
            {
                return false;
            }

            if (CompareMethodName && !string.Equals(x.MethodName, y.MethodName, StringComparison.Ordinal))
            {
                return false;
            }

            if (CompareFileName && !string.Equals(x.FileName, y.FileName, StringComparison.Ordinal))
            {
                return false;
            }

            if (CompareUser && !string.Equals(x.User, y.User, StringComparison.Ordinal))
            {
                return false;
            }

            if (CompareLineNumber && !x.LineNumber.Equals(y.LineNumber))
            {
                return false;
            }

            if (CompareProcessId && !x.ProcessId.Equals(y.ProcessId))
            {
                return false;
            }

            if (CompareThread && !x.ThreadId.Equals(y.ThreadId))
            {
                return false;
            }

            if (CompareLineNumber && !x.LineNumber.Equals(y.LineNumber))
            {
                return false;
            }

            if (CompareLevel && !x.Level.Equals(y.Level))
            {
                return false;
            }
            if (CompareParameters)
            {
                if ((x.AdditionalProperties is null && y.AdditionalProperties is not null) || (x.AdditionalProperties is not null && y.AdditionalProperties is null))
                {
                    return false;
                }

                if (x.AdditionalProperties is null && y.AdditionalProperties is null)
                {
                    return true;
                }

                return x.AdditionalProperties is not null &&
                       y.AdditionalProperties is not null &&
                       x.AdditionalProperties.SequenceEqual(y.AdditionalProperties);
            }

            return true;
        }

        public int GetHashCode(IAnalogyLogMessage obj)
        {
            unchecked
            {
                var hashCode = CompareDate ? obj.Date.GetHashCode() : 1;

                if (CompareId)
                {
                    hashCode = (hashCode * 397) ^ obj.Id.GetHashCode();
                }

                if (CompareText)
                {
                    hashCode = (hashCode * 397) ^ (obj.Text is not null ? StringComparer.Ordinal.GetHashCode(obj.Text) : 0);
                }

                if (CompareSource)
                {
                    hashCode = (hashCode * 397) ^ (obj.Source is not null ? StringComparer.Ordinal.GetHashCode(obj.Source) : 0);
                }

                if (CompareMethodName)
                {
                    hashCode = (hashCode * 397) ^ (obj.MethodName is not null ? StringComparer.Ordinal.GetHashCode(obj.MethodName) : 0);
                }

                if (CompareFileName)
                {
                    hashCode = (hashCode * 397) ^ (obj.FileName is not null ? StringComparer.Ordinal.GetHashCode(obj.FileName) : 0);
                }

                if (CompareLineNumber)
                {
                    hashCode = (hashCode * 397) ^ (int)obj.LineNumber;
                }

                if (CompareClass)
                {
                    hashCode = (hashCode * 397) ^ (int)obj.Class;
                }

                if (CompareLevel)
                {
                    hashCode = (hashCode * 397) ^ (int)obj.Level;
                }

                if (CompareModule)
                {
                    hashCode = (hashCode * 397) ^ (obj.Module is not null ? StringComparer.Ordinal.GetHashCode(obj.Module) : 0);
                }

                if (CompareProcessId)
                {
                    hashCode = (hashCode * 397) ^ obj.ProcessId;
                }

                if (CompareThread)
                {
                    hashCode = (hashCode * 397) ^ obj.ThreadId;
                }
                if (CompareParameters)
                {
                    if (obj.AdditionalProperties?.Count > 0)
                    {
                        foreach (var parameter in obj.AdditionalProperties)
                        {
                            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(parameter.Key);
                            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(parameter.Value);
                        }
                    }
                }

                if (CompareUser)
                {
                    hashCode = (hashCode * 397) ^ (obj.User is not null ? StringComparer.Ordinal.GetHashCode(obj.User) : 0);
                }
                return hashCode;
            }
        }
    }
}