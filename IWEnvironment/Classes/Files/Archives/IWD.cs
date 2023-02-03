using System.IO.Compression;

namespace IWEnvironment.Classes.Files.Archives
{
    internal class IWD : ZipArchive
    {
        FileInfo? File { get; set; }
        public IWD(Stream stream) : base(stream) { }
        public static IWD FromFile(string path) => FromFile(new FileInfo(path));
        public static IWD FromFile(FileInfo file) => new IWD(file.OpenRead()) { File = file };
    }
}