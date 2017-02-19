using System;
using System.IO;
using System.Windows.Forms;

namespace DirSync
{
    public class Program
    {
        string fromDirString = @"";
        string toDirString = @"";
        string fromDirBox = @"";
        string toDirBox = @"";

        //Reads the files in the destination and compares the date modified, then takes the newest files.
        public string FromDir()
        {
            //Initialize StreamReader
            StreamReader FromDir = null;
            FromDir = new StreamReader(Form1.);
            //fromDirString = this.fromDirBox;

            while (fromDirString != "")
            {
                //string fromDirString = fromDirBox.Text;
            }
            return fromDirString;

        }

        // Initialize StreamWriter
        public string ToDir()
        {
            // Recursively copies files according to user defined directories
            StreamWriter ToDir = null;
            ToDir = new StreamWriter(toDirString);

            return toDirString;
        }

        //Uses toDir method to copy files from user defined 'from' directory, to the user defined 'to' directory.
        //Also initializes and closes StreamReader & StreamWriter
        public void ProcessFiles()
        {
            
            while (fromDirString != "" && toDirString != "")
            {

                FromDir();
                ToDir();
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initialize Form1
            Application.Run(new Form1());


            


            

        }
    }
}
