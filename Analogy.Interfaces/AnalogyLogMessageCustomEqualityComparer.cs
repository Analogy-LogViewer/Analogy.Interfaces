﻿using System.Collections.Generic;
using System.Linq;

namespace Analogy.Interfaces
{
    public class AnalogyLogMessageCustomEqualityComparer : IEqualityComparer<AnalogyLogMessage>
    {
        public bool CompareDate { get; set; } = true;
        public bool CompareId { get; set; } = true;
        public bool CompareText { get; set; } = true;
        public bool CompareCategory { get; set; } = true;
        public bool CompareSource { get; set; } = true;
        public bool CompareModule { get; set; } = true;
        public bool CompareMethodName { get; set; } = true;
        public bool CompareFileName { get; set; } = true;
        public bool CompareUser { get; set; } = true;
        public bool CompareLineNumber { get; set; } = true;
        public bool CompareProcessId { get; set; } = true;
        public bool CompareThread { get; set; } = true;
        public bool CompareLevel { get; set; } = true;
        public bool CompareClass { get; set; } = true;
        public bool CompareParameters { get; set; } = true;

        public bool Equals(AnalogyLogMessage? x, AnalogyLogMessage? y)
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

            if (CompareText && !x.Text.Equals(y.Text))
            {
                return false;
            }

            if (CompareCategory && x.Category != y.Category)
            {
                return false;
            }

            if (CompareSource && x.Source != y.Source)
            {
                return false;
            }

            if (CompareModule && x.Module != y.Module)
            {
                return false;
            }

            if (CompareMethodName && x.MethodName != y.MethodName)
            {
                return false;
            }

            if (CompareFileName && x.FileName != y.FileName)
            {
                return false;
            }

            if (CompareUser && x.User != y.User)
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
                if (x.AdditionalInformation is null && y.AdditionalInformation != null ||
                    x.AdditionalInformation != null && y.AdditionalInformation is null)
                {
                    return false;
                }
                return x.AdditionalInformation is null && y.AdditionalInformation is null ||
                       x.AdditionalInformation.SequenceEqual(y.AdditionalInformation);
            }

            return true;
        }

        public int GetHashCode(AnalogyLogMessage obj)
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
                    hashCode = (hashCode * 397) ^ (obj.Text != null ? obj.Text.GetHashCode() : 0);
                }

                if (CompareCategory)
                {
                    hashCode = (hashCode * 397) ^ (obj.Category != null ? obj.Category.GetHashCode() : 0);
                }

                if (CompareSource)
                {
                    hashCode = (hashCode * 397) ^ (obj.Source != null ? obj.Source.GetHashCode() : 0);
                }

                if (CompareMethodName)
                {
                    hashCode = (hashCode * 397) ^ (obj.MethodName != null ? obj.MethodName.GetHashCode() : 0);
                }

                if (CompareFileName)
                {
                    hashCode = (hashCode * 397) ^ (obj.FileName != null ? obj.FileName.GetHashCode() : 0);
                }
                if (CompareLineNumber)
                { hashCode = (hashCode * 397) ^ obj.LineNumber; }

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
                    hashCode = (hashCode * 397) ^ (obj.Module != null ? obj.Module.GetHashCode() : 0);
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
                    if (obj.AdditionalInformation != null && obj.AdditionalInformation.Any())
                    {
                        foreach (var parameter in obj.AdditionalInformation)
                        {
                          hashCode = (hashCode * 397) ^ parameter.GetHashCode();
                        }
                    }
                }

                if (CompareUser)
                {
                    hashCode = (hashCode * 397) ^ (obj.User != null ? obj.User.GetHashCode() : 0);
                }
                return hashCode;
            }
        }
    }
}
