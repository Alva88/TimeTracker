using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public static class AppSettings
    {
        static string _tempDir = "";
        public static string TempDir
        {
            get
            {
                return _tempDir;
            }
            set
            {
                _tempDir = value;
            }
        }
    }
}
