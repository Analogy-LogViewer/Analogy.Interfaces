namespace Analogy.Interfaces
{
    public interface IRawSQLInteractor
    {
        /// <summary>
        /// object that enables the User Control to change the RAW SQL filter (normally LogMessage User Control).
        /// </summary>
        void SetRawSQLHandler(ILogRawSQL rawSQLHandler);
    }
}