using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateTool.Class
{
    public class ReaderFactory
    {
        public static string GetText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
