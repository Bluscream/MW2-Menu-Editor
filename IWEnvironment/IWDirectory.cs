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
        public DirectoryInfo Directory { get; set; }
        public List<IWDirectory> SubDirectories { get; set; } = new();
        public List<IWFile> Files { get; set; } = new();
        public static IWDirectory FromDirectory(string path) => FromDirectory(new DirectoryInfo(path));
        public static IWDirectory FromDirectory(DirectoryInfo directory) => new() { Directory = directory };

        public void Load()
        {
            // TODO: do eet
        }

        public override string ToString()
        {
            return Directory.FullName;
        }

        public void PrintRecursive(int depth = 0)
        {
            if (SubDirectories.Count < 1 || Files.Count < 1) Load();
            foreach (var SubDirectory in SubDirectories)
            {
                Console.WriteLine(new string('\t', depth) + ToString() + "/");
                PrintRecursive(depth+1);
            }
            foreach (var File in Files)
            {
                Console.WriteLine(new string('\t', depth)+File.ToString());
            }
        }
    }
}
