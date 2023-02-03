using System.Runtime.InteropServices;
using Bluscream;
using MW2_Menu.Menu;
// using CppAst;

namespace MW2_Menu
{
    public class IWMenu : MenuItemBase
    {
        public FileInfo? File { get; private set; }
        public string? Text { get; private set; }
        public List<menuDef> MenuDefs { get; private set; } = new List<menuDef>();
        // public CppCompilation? Compilation { get; private set; }
        public static IWMenu FromFile(FileInfo file)
        {
            return IWMenu.FromText(file.ReadAllText()); // Compilation = CppParser.Parse(file.ReadAllText())
        }
        public static IWMenu FromText(string text) {
            return new IWMenu() { Text = text };
        }
    }
}