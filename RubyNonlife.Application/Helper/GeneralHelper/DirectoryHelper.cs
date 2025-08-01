using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public static class DirectoryHelper
    {
        public static void CreateDirectories()
        {
            var basePath = AppContext.BaseDirectory; // Gets the application's base directory
            var internalLogDir = Path.Combine(basePath, "internal_logs");
            var logDir = Path.Combine(basePath, "logs");

            if (!Directory.Exists(internalLogDir))
            {
                Directory.CreateDirectory(internalLogDir);
            }

            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }
        }
    }
}
