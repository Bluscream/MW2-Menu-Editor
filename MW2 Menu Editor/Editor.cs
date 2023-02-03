using MW2_Menu;

namespace MW2_Menu_Editor
{
    public partial class Editor : Form
    {
        IWMenu CurrentMenu { get; set; }
        public Editor()
        {
            InitializeComponent();
            editor_Load();
        }
        public void editor_Load()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"S:\Steam\steamapps\common\Call of Duty Modern Warfare 2",
                Title = "Browse Menu Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "menu",
                Filter = "menu files (*.menu)|*.menu",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(openFileDialog1.FileName);
                CurrentMenu = IWMenu.FromFile(file);
                Console.WriteLine(CurrentMenu.ToString());
            }
        }
    }
}