namespace Analogy.Interfaces.DataTypes
{    
    public class AnalogyProgressReport
    {
        public string Prefix { get; set; }
        public int Processed { get; set; }
        public int Total { get; set; }
        public string FinishedProcessing { get; set; }
        public AnalogyProgressReport(string prefix, int processed, int total, string finishedProcessing) => (Prefix, Processed, Total, FinishedProcessing) = (prefix, processed, total, finishedProcessing);
    }
}
