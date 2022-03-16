using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overFlood
{
    public class Utilities
    {
        public static string OpenFileDialog(string title)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = title;
            openFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Documents");
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        public static string[] LoadFile(string filename)
        {
            IEnumerable<string> lines = File.ReadLines(filename);
            string[] result = new string[lines.Count()];
            result = lines.ToArray();
            return result;
        }

        public static string[] LoadAccounts(string filename)
        {
            IEnumerable<string> lines = File.ReadLines(filename);
            string[] result = new string[lines.Count()];
            result = lines.ToArray();
            return result;
        }
    }
}
