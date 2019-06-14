using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decepticon;
using System.IO;

namespace Decepticon.Tests
{
    [TestClass]
    public class ActiveConfigurationTests
    {
        [TestMethod]
        public void GetActiveConfigurationValueTest_NetCore()
        {
            var result = ActiveConfiguration.Value;

            Assert.IsNotNull(result);

            System.Console.WriteLine(result);
        }
    }
}
