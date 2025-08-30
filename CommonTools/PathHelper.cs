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

    }
}
