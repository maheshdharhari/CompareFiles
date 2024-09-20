using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new FolderBrowserDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFirstDirectoryPath.Text = openFileDialog1.SelectedPath;
            }
        }

        private void buttonBrowseSecond_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new FolderBrowserDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSecondDirectoryPath.Text = openFileDialog1.SelectedPath;
            }
        }

        private async void buttonCompare_Click(object sender, EventArgs e)
        {
            var searchFilesInDirectory = await SearchFilesInDirectory(textBoxFirstDirectoryPath.Text, textBoxSecondDirectoryPath.Text);
            var searchString = string.Join(Environment.NewLine, searchFilesInDirectory.ToArray());
            textBoxResult.Text = searchString;

        }

        private async Task<IEnumerable<string>> SearchFilesInDirectory(string s, string s1)
        {
            var searchPattern = !string.IsNullOrEmpty(textBoxExtension.Text) ? "*." + textBoxExtension.Text : "*.*";
                var firstDirSearch = await DirSearch(s, searchPattern);
                var secondDirSearch = await DirSearch(s1, searchPattern);
                var searchResult=firstDirSearch.Except(secondDirSearch);

            return searchResult.ToList();
           
        }
        private static Task<List<string>> DirSearch(string sDir, string searchPattern)
        {
            var filesName = new List<string>();
            try
            {
                filesName.AddRange(Directory.GetFiles(sDir, searchPattern).Select(f => Path.GetFileName(f)));

                foreach (var d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d, searchPattern);
                }
            }
            catch (Exception exception)
            {
                //Console.WriteLine(exception.Message);
            }

            return Task.FromResult(filesName);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxResult.Text))
                Clipboard.SetText(textBoxResult.Text);
        }
    }
}