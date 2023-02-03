using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWEnvironment.Classes.Files
{
    public class IWFile
    {
        public IWDirectory? Root { get; set; }
        public FileInfo File { get; set; }
        public override string ToString()
        {
            return File.FullName;
        }
    }
}
