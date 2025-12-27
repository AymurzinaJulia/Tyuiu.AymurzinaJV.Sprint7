using System;
using System.Collections.Generic;

namespace Tyuiu.AymurzinaJV.Sprint7.Project.V7
{
    public static class DataService
    {
        
        public static bool CheckFileExists(string path)
        {
            return System.IO.File.Exists(path);
        }
    }
}
