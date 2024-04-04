using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFromReport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new FolderBrowserDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new FolderBrowserDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.SelectedPath;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var searchFilesInDirectory = await SearchFilesInDirectory(textBox1.Text, textBox2.Text);
            var searchString = string.Join(Environment.NewLine, searchFilesInDirectory.ToArray());
            textBox4.Text = searchString;

        }

        private async Task<IEnumerable<string>> SearchFilesInDirectory(string s, string s1)
        {
            var searchPattern = !string.IsNullOrEmpty(textBox3.Text) ? "*." + textBox3.Text : "*.*";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
                Clipboard.SetText(textBox4.Text);
        }
    }
}