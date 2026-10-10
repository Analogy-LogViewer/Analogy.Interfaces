using Analogy.Interfaces.DataTypes;
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
            Assert.IsNotNull(message.Source);
            Assert.IsNotNull(message.FileName);
            Assert.IsNotNull(message.MethodName);
            Assert.IsNotNull(message.Module);
            Assert.IsNotNull(message.User);
        }
        [TestMethod]
        public void TestAdditionalProperties()
        {
            AnalogyLogMessage message = new AnalogyLogMessage();
            Assert.IsNotNull(message.AdditionalProperties is null);
            message.AddOrReplaceAdditionalProperty("test", "test", System.StringComparer.Ordinal);
            Assert.IsNotNull(message.AdditionalProperties?.Count is 1);
            Assert.IsNotNull(message.AdditionalProperties?["test"] is "test");
        }
    }
}