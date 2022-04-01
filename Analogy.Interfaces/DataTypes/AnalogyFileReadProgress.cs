namespace Analogy.Interfaces.DataTypes
{
    public struct AnalogyFileReadProgress
    {
        public AnalogyFileReadProgressType ProgressType { get; }
        /// <summary>
        ///Number of items processed in this report (normally one message per report).
        /// </summary>
        public long TotalProcessedInThisReport { get; }
        /// <summary>
        ///Total processed entries (lines or messages)
        /// </summary>
        public long TotalProcessed { get; }
        /// <summary>
        ///Total entries (lines or messages) in file
        /// </summary>
        public long TotalEntries { get; }

        public AnalogyFileReadProgress(AnalogyFileReadProgressType progressType, long totalProcessedInThisReport, long totalProcessed, long totalEntries)
        {
            ProgressType = progressType;
            TotalProcessed = totalProcessed;
            TotalEntries = totalEntries;
            TotalProcessedInThisReport = totalProcessedInThisReport;
        }
    }
}
