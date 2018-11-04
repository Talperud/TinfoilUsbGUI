
// A GUI for installing NSP files using tinfoil

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TinfoilInstaller
{
    public partial class Form1 : Form
    {
        private bool UsingFolder = false;
        private string NspPath;
        private string FolderPath;

        public Form1()
        {
            InitializeComponent();

            //Installs the pyusb library
            System.Diagnostics.Process PyusbInstaller = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo PyusbInstallerInfo = new System.Diagnostics.ProcessStartInfo();

            PyusbInstallerInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            PyusbInstallerInfo.FileName = "cmd.exe";
            PyusbInstallerInfo.Arguments = "/C pip install pyusb";

            PyusbInstaller.StartInfo = PyusbInstallerInfo;
            PyusbInstaller.Start();
        }

        //opens the File explorer and inputs the nsp name into the listbox
        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "nsp files (*.nsp)|*.nsp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NspLBx.Items.Clear();

                NspPath = openFileDialog.FileName.Replace('\\', '/');
                string NspName = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf('\\') + 1);

                NspLBx.Items.Add(NspName);

                UsingFolder = false;
            }
        }

        //opens the Folder explorer and inputs the nnsp names into the listbox
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                NspLBx.Items.Clear();

                FolderPath = folderBrowserDialog.SelectedPath.Replace('\\', '/');
                string[] NspNameArray = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.nsp");

                string NspNameFb;

                for (int i = 0; i < NspNameArray.Length; i++)
                {
                    NspNameFb = NspNameArray[i].Substring(NspNameArray[i].LastIndexOf('\\') + 1);

                    NspLBx.Items.Add(NspNameFb);
                }

                UsingFolder = true;
            }
        }

        //Starts the Python script with the correct parameters
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(NspLBx.Items.Count > 0)
            {

                System.Diagnostics.Process Upload = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo UploadInfo = new System.Diagnostics.ProcessStartInfo();

                UploadInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                UploadInfo.FileName = "cmd.exe";

                if (UsingFolder == true)
                {
                    UploadInfo.Arguments = "/C usb_install_pc.py \"" + FolderPath + "\"";
                }

                else
                {
                    UploadInfo.Arguments = "/C usb_install_pc_file.py \"" + NspPath.Substring(0,NspPath.LastIndexOf('/')) + "\" \"" + NspPath + "\"";
                }

                Upload.StartInfo = UploadInfo;
                Upload.Start();
            }

            else
            {
                MessageBox.Show("Select a file first!");
            }

        }
    }
}
