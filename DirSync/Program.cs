using System;
using System.IO;
using System.Windows.Forms;

namespace DirSync
{
    public class Program
    {

        /// 
        /// The main entry point for the application.
        /// 
        /// 
        [STAThread]
        public static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initialize Form1
            Application.Run(new Form());

            //Initialize new Form instance, so I can control the inputs from the Form
            Form form = new Form();

            //Get "from" and "to" directory path for copying, then set it to the strings "from" and "to"
            string from = form.fromDirBox.Text;
            string to = form.toDirBox.Text;

            





        }

    }
}

