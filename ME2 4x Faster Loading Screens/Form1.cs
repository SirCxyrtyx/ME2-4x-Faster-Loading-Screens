using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ME2_4x_Faster_Loading_Screens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gamePath = @"C:\Program Files (x86)\Origin Games\Mass Effect 2";

        IEnumerable<string> biks;

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                DefaultDirectory = gamePath,
                DefaultFileName = gamePath,
                EnsurePathExists = true,
                Multiselect = false,
                Title = "Select ME2 Folder"
            };
            dlg.IsFolderPicker = true;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                gamePath = dlg.FileName;
                folderLocationText.Text = gamePath;
                biks = Directory.EnumerateFiles(gamePath, "load_*.bik", SearchOption.AllDirectories);
                biks = biks.Where(bik => !(bik.EndsWith("load_f19.bik") || bik.EndsWith("load_f99.bik")));
                textBox1.Text = biks.Aggregate((a, b) => a + "\r\n" + b);
                textBoxLabel.Text = "Files To Convert:";
                convertButton.Enabled = true;
                convertButton.Text = "Convert";
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string doneText = "Done!";

            convertButton.Text = "Converting";

            Task.WhenAll(biks.Select(bik =>
                Task.Run(() => EditBIK(bik))
            )).Wait();
            convertButton.Text = doneText;
            convertButton.Enabled = false;
            textBox1.Text = biks.Aggregate((a, b) => a + "\r\n" + b);
            textBoxLabel.Text = "Converted Files";
        }

        static void EditBIK(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            fs.Seek(28, SeekOrigin.Begin);
            fs.Write(BitConverter.GetBytes(60), 0, 4);
            fs.Close();
        }
    }
}
