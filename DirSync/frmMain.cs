using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library;

namespace DirSync
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public frmMain()
        {
            InitializeComponent();
   
        }

        //On button click from the form, compares files in "From" to "To" dir, only copies
        // & overwrites "To" files..
        private void okButton_Click(object sender, EventArgs e)
        {
            //initialize frmMain
            frmMain form = new frmMain();

            string result = "";


            //For storing directory strings
            List<string> list = new List<string>();
            list.Add(fromDirBox.Text);
            list.Add(toDirBox.Text);

            //check if file paths are valid
            Engine.IsValidPath(fromDirBox.Text);
            Engine.IsValidPath(toDirBox.Text);
            Engine.CheckPath(fromDirBox.Text, out result);
            Engine.CheckPath(toDirBox.Text, out result);

            //showing box text from fromDirBox
            MessageBox.Show(this.fromDirBox.Text);

        }


    }
}
