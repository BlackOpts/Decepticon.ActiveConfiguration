using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decepticon;
using System.IO;

namespace Decepticon.NetFramework.Tests
{
    [TestClass]
    public class ActiveConfigurationTests
    {
        [TestMethod]
        public void GetActiveConfigurationValueTest_NetFramework()
        {
            var result = ActiveConfiguration.Value;

            Assert.IsNotNull(result);

            System.Console.WriteLine(result);
        }
    }
}
