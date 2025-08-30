using System;
using System.IO;

namespace CommonTools
{
    public  class PathHelper
    {

        public static string GetDefaultProjectPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                ConstantHelper.SoftwareName, "Projects");
        }

        public static string GetHMIRunFilePath(string projectPath)
        {
            return Path.Combine(projectPath, "Output", "HMIRUN.exe");
        }
    }
}
