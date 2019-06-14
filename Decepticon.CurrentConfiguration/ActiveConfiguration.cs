using System.IO;

namespace Decepticon
{
    /// <summary>
    /// Represents the current build configuration object
    /// </summary>
    public static class ActiveConfiguration
    {
        /// <summary>
        /// Get the current configuration name when the project was built.
        /// Returns null on errors.
        /// </summary>
        public static string Value
        {
            get
            {
                // Try to get the value from the configuration variable
                try
                {
                    var path = Path.GetTempPath() + "Decepticon.log";
                    var configName = File.ReadAllText(path);
                    return configName != null ? configName.Trim() : null;
                }
                catch { }
                
                return null;
            }
        }
    }
}
