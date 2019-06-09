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
                try
                {
                    var path = Directory.GetCurrentDirectory() + "\\CurrentConfig.txt";
                    var configName = File.ReadAllText(path);
                    return configName != null ? configName.Trim() : null;
                }
                catch (FileNotFoundException)
                {
                    return null;
                }
            }
        }
    }
}
