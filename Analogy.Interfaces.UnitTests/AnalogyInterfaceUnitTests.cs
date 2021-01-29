using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Analogy.Interfaces.UnitTests
{
    [TestClass]
    public class AnalogyInterfaceUnitTests
    {
        [TestMethod]
        public void TestAnalogyLogMessageIsNotNull()
        {
            AnalogyLogMessage message = new AnalogyLogMessage();
            Assert.IsNotNull(message.Text);
            Assert.IsNotNull(message.Category);
            Assert.IsNotNull(message.Source);
            Assert.IsNotNull(message.FileName);
            Assert.IsNotNull(message.MethodName);
            Assert.IsNotNull(message.Module);
            Assert.IsNotNull(message.User);

        }

        public void TestAnalogyMessagesTypes()
        {
            AnalogyLogMessage m1 = new AnalogyInformationMessage("text", "Source");
            AnalogyLogMessage m2 = new AnalogyErrorMessage("text", "Source");
            AnalogyLogMessage m3 = new AnalogyWarningMessage("text", "Source");
            AnalogyLogMessage m4 = new AnalogyDebugMessage("text", "Source");
            AnalogyLogMessage m5 = new AnalogyCriticalMessage("text", "Source");
        }
    }
}
