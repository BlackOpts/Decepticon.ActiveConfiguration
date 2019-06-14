using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decepticon;
using System.IO;

namespace Decepticon.UnitTests
{
    [TestClass]
    public class ActiveConfigurationTests
    {
        const string ConfigFileName = "Decepticon.log";

        private void CreateConfigFile(string content)
        {
            // Create fake configuration file as done in the target file
            var tempPath = $"{Path.GetTempPath()}{ConfigFileName}";
            
            File.WriteAllText(tempPath, content);

            System.Console.WriteLine(tempPath);
        }

        [TestInitialize]
        public void RemoveConfigFile()
        {
            var tempDir = $"{Path.GetTempPath()}{ConfigFileName}";

            if (File.Exists(tempDir))
            {
                File.Delete(tempDir);
            }
        }

        [TestMethod]
        public void GetActiveConfigurationValueTest()
        {
            var value = System.DateTime.Now.Ticks.ToString();
            CreateConfigFile(value);

            var result = ActiveConfiguration.Value;

            Assert.IsNotNull(result);
            Assert.AreEqual(value, result, "Config value is not correct");

            System.Console.WriteLine(result);
        }

        [TestMethod]
        public void GetActiveConfigurationValueTest_Trimed()
        {
            var value = "    My value  ";
            CreateConfigFile(value);

            var result = ActiveConfiguration.Value;

            Assert.IsNotNull(result);
            Assert.AreEqual(value.Trim(), result, "The config name is not trimed properly");

            System.Console.WriteLine(result);
        }

        [TestMethod]
        public void GetActiveConfigurationValueTest_FileNotFound_ReturnNull()
        {
            var result = ActiveConfiguration.Value;

            Assert.IsNull(result);
        }
    }
}
