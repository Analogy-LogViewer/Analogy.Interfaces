namespace Analogy.Interfaces.DataTypes
{
    public struct AnalogyFileReadProgress
    {
        private AnalogyFileReadProgressType ProgressType { get; }
        /// <summary>
        /// total processed entries (lines or messages)
        /// </summary>
        public int TotalProcessed { get; }
        /// <summary>
        /// total entries (lines or messages) in file
        /// </summary>
        public int TotalEntries { get; }

        public AnalogyFileReadProgress(AnalogyFileReadProgressType progressType, int totalProcessed, int totalEntries)
        {
            ProgressType = progressType;
            TotalProcessed = totalProcessed;
            TotalEntries = totalEntries;
        }
    }
}
