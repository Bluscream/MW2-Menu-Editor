using System.Windows.Forms;

namespace IWEnvironment
{
    public class IWEnvorinment : IWDirectory
    {
        public static IWEnvorinment? PickDirectoy()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return FromDirectory(fbd.SelectedPath) as IWEnvorinment;
                }
                else if (result == DialogResult.Cancel) return null;
            }
            PickDirectoy();
            return null;
        }

        // TODO: HERE
    }
}