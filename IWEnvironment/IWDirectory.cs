using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWEnvironment.Classes.Files;

namespace IWEnvironment
{
    public class IWDirectory
    {
        public IWDirectory? Root { get; set; }
        public IWDirectory? Parent { get; set; }
        public DirectoryInfo? Directory { get; set; }
        public List<IWDirectory> SubDirectories { get; set; } = new();
        public List<IWFile> Files { get; set; } = new();
        public IWDirectory()
        {

        }
        public static IWEnvorinment FromDirectory(string path) => FromDirectory(new DirectoryInfo(path));
        public static IWEnvorinment FromDirectory(DirectoryInfo directory) => new() { Directory = directory };

        public void Load()
        {
            SubDirectories
        }
    }
}
