namespace Analogy.Interfaces.DataTypes
{
    public struct AnalogyFileReadProgress
    {
        public AnalogyFileReadProgressType ProgressType { get; }
        /// <summary>
        /// total processed entries (lines or messages)
        /// </summary>
        public long TotalProcessed { get; }
        /// <summary>
        /// total entries (lines or messages) in file
        /// </summary>
        public long TotalEntries { get; }

        public AnalogyFileReadProgress(AnalogyFileReadProgressType progressType, long totalProcessed, long totalEntries)
        {
            ProgressType = progressType;
            TotalProcessed = totalProcessed;
            TotalEntries = totalEntries;
        }
    }
}
