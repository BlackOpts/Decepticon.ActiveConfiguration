using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decepticon;

namespace Decepticon.Tests
{
    [TestClass]
    public class ActiveConfigurationTests
    {
        [TestMethod]
        public void GetActiveConfigurationValueTest()
        {
            var result = ActiveConfiguration.Value;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Trim(), result, "The config name is not trimed properly");

            System.Console.WriteLine(result);
        }
    }
}
