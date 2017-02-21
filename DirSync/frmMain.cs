using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library;
using System.IO;
using System.Diagnostics;

namespace DirSync
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public frmMain()
        {
            InitializeComponent();
   
        }

        // This method is to recursively look and copy directories
        private static void DirCopy(string fromDir, string toDir, bool copySubDir)
        {
            //find sub-directories
            DirectoryInfo dir = new DirectoryInfo(fromDir);

            if (!dir.Exists) 
            {
                throw new DirectoryNotFoundException("Invalid directory in: " + fromDir);
            }



            DirectoryInfo[] dirs = dir.GetDirectories();
            //if the directory doesn't exist, create it
            if (!Directory.Exists(toDir))
            {
                //create the destination directory
                Directory.CreateDirectory(toDir); 
            }

            //if the destination Dir exists, get the WriteTime on fromDir, and toDir.
            while (Directory.Exists(toDir))
            {
                DateTime dtFrom = File.GetLastWriteTime(fromDir);
                DateTime dtTo = File.GetLastWriteTime(toDir);

                //if destination directory is older than the original "from" directory, 
                // recursively copy from "fromDir" to "toDir"

                if (dtFrom > dtTo)
                {
                    //Grab the files in the directory and copy them to destination
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        string temppath = Path.Combine(toDir, file.Name);
                        file.CopyTo(temppath, false);
                    }
                }
                else
                {
                    copySubDir = false;
                }

                // If copying dirs, do the full copying
                if (copySubDir)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(toDir, subdir.Name);
                        DirCopy(subdir.FullName, temppath, copySubDir);
                    }
                }
            }
        }




        //On button click from the form, compares files in "From" to "To" dir, only copies
        // & overwrites "To" files..
        private void okButton_Click(object sender, EventArgs e)
        {
            //initialize frmMain
            frmMain form = new frmMain();

            //check if file paths are valid
            string result = "";

            Engine.IsValidPath(fromTextBox.Text);
            Engine.IsValidPath(toTextBox.Text);
            Engine.CheckPath(fromTextBox.Text, out result);
            Engine.CheckPath(toTextBox.Text, out result);

            //execute dircopy method on okButton click
            DirCopy(".", @".\temp", true);

            /*
            string result = "";

            //For storing directory strings
            List<string> list = new List<string>();
            list.Add(fromTextBox.Text);
            list.Add(toTextBox.Text);
            */
            //showing box text from fromDirBox

            //MessageBox.Show(fromTextBox.Text);
            


        }

        private void fromDirBox_TextChanged(object sender, EventArgs e)
        {
            fromTextBox.Text = Convert.ToString(fromTextBox.Text);

        }

        private void toDirBox_TextChanged(object sender, EventArgs e)
        {
            toTextBox.Text = Convert.ToString(toTextBox.Text);

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
