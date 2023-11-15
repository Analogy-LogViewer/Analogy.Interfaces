namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyLogMessageUpdaterEventData
    {
        public IAnalogyLogMessage Message { get; set; }
        public AnalogyLogMessageUpdaterEventStatus Type { get; set; }

        public AnalogyLogMessageUpdaterEventData(IAnalogyLogMessage message, AnalogyLogMessageUpdaterEventStatus type)
        {
            Message = message;
            Type = type;
        }
    }
}