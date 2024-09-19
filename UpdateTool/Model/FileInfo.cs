using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateTool.Model
{
    public class FileInfo
    {
        public FileInfo() { }
        public int INDEX { get; set; }
        public string NAME { get; set; }
        public DateTime DATE { get; set; }

        public string TRANGTHAI { get; set; }
        public string path { get; set; }
        public string MESS { get; set; }
        public FileInfo(int INDEX, string NAME, DateTime DATE, string path, string TRANGTHAI = null,string MESS = null)
        {
            this.INDEX = INDEX;
            this.NAME = NAME;
            this.DATE = DATE;
            this.TRANGTHAI = TRANGTHAI;
            this.path = path;
            this.MESS = MESS;
        }
    }
}
