using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace DirSync
{
    public partial class frmMainDos : Form
    {
        public frmMainDos()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            // check form, and exit if no bueno
            if (!CheckForm())
            {
                return;
            }

            // declare an instance of EngineDos
            var engineDos = new Library.EngineDos(Properties.Settings.Default.logDir, this.fromTextBox.Text, this.toTextBox.Text);

            // put all non-recoverable error handling is outside of libraries because if you use this library 
            // in another application, you dont know how that application wants to deal with the errors.
            try
            {
                engineDos.Go();
                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nope.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private bool CheckForm()
        {

            // error providers are fun

            bool formValid = true;

            errorProvider1.Clear();

            if (this.fromTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(this.fromTextBox, "No bueno.");
                formValid = false;
            }

            
            if (this.toTextBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(this.toTextBox, "No bueno.");
                formValid = false;
            }

            return formValid;
        }
    }
}
