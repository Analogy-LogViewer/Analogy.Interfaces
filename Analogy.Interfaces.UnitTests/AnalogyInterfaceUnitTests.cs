using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Analogy.Interfaces.UnitTests
{
    [TestClass]
    public class AnalogyInterfaceUnitTests
    {
        [TestMethod]
        public void TestAnalogyLogMessageIsNotNull()
        {
            IAnalogyLogMessage message = new AnalogyLogMessage();
            Assert.IsNotNull(message.Text);
            Assert.IsNotNull(message.Source);
            Assert.IsNotNull(message.FileName);
            Assert.IsNotNull(message.MethodName);
            Assert.IsNotNull(message.Module);
            Assert.IsNotNull(message.User);

        }

        public void TestAnalogyMessagesTypes()
        {
           IAnalogyLogMessage m1 = new AnalogyInformationMessage("text", "Source");
           IAnalogyLogMessage m2 = new AnalogyErrorMessage("text", "Source");
           IAnalogyLogMessage m3 = new AnalogyWarningMessage("text", "Source");
           IAnalogyLogMessage m4 = new AnalogyDebugMessage("text", "Source");
           IAnalogyLogMessage m5 = new AnalogyCriticalMessage("text", "Source");
        }
    }
}
