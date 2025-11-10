namespace Analogy.Interfaces
{
    public interface IRawSQLInteractor
    {
        /// <summary>
        /// object that enables the User Control to change the RAW SQL filter (normally LogMessage User Control)
        /// </summary>
        /// <param name="rawSQLInteractor"></param>
        void SetRawSQLHandler(ILogRawSQL rawSQLHandler);
    }
}