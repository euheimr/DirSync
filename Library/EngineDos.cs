using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class EngineDos
    {

        public string LogPath { get; set; }
        public string LogFilePath { get; set; }
        public string FromDir { get; set; }
        public string ToDir { get; set; }


        // define the event handler (what parameteres)
        public delegate void StatusMessageEventHandler(string message);

        // declare an instance of the handler so we can call it
        public event StatusMessageEventHandler StatusMessage;

        /// <summary>
        /// this is the "Constructor" method for the class.  
        /// it take the intialization parameters.
        /// </summary>
        /// <param name="logPath"></param>
        /// <param name="fromDir"></param>
        /// <param name="toDir"></param>
        public EngineDos(string logPath, string fromDir, string toDir)
        {
            this.LogPath = logPath.Trim().ToDirSlashString();  // ToDirSlashString() is an extension method. these are awesome. take a look at the ExtensionMethods class
            this.LogFilePath = this.LogPath + System.DateTime.Now.ToFileDateTimeString() + ".txt";  // so is ToFileDateTimeString() :-)
            this.FromDir = fromDir.Trim().ToDirSlashString();
            this.ToDir = toDir.Trim().ToDirSlashString();
            

        }


        public void Go()
        {
            this.WriteToLog(this.FromDir + " -> " + this.ToDir);
            this.DirCopy(this.FromDir, this.ToDir);


            // need to make sure that files in source dont exist in destination too


            this.WriteToLog("Done.");
        }

        /// <summary>
        /// this is a private method used by the engine
        /// </summary>
        /// <param name="fromDir"></param>
        /// <param name="toDir"></param>
        private void DirCopy(string fromDir, string toDir)
        {

            // no error trapping in here.  if it fails, there isnt anything to be done, let it error propogate to the outside
            DirectoryInfo fromDirInfo = new DirectoryInfo(fromDir);

            DirectoryInfo[] fromDirs = fromDirInfo.GetDirectories();

            if (!Directory.Exists(toDir))
            {
                Directory.CreateDirectory(toDir);
            }

            if (Directory.Exists(toDir))
            {
                FileInfo[] files = fromDirInfo.GetFiles();

                foreach (FileInfo fromFileInfo in files)
                {


                    string toFilePath = Path.Combine(toDir, fromFileInfo.Name);
                    FileInfo toFileInfo = new FileInfo(toFilePath);

                    // is the file different?  file doesnt exist OR size OR write time should be good nuff check
                    if (!toFileInfo.Exists || fromFileInfo.Length != toFileInfo.Length || fromFileInfo.LastWriteTime > toFileInfo.LastWriteTime)
                    {
                        this.WriteToLog("Copying " + fromFileInfo.FullName + " -> " + toFilePath + "...");
                        fromFileInfo.CopyTo(toFilePath, true);
                    }

                }

                foreach (DirectoryInfo fromSubDirInfo in fromDirs)
                {
                    string toSubDirPath = Path.Combine(toDir, fromSubDirInfo.Name);
                    DirCopy(fromSubDirInfo.FullName, toSubDirPath);
                }

            }

        }

        /// <summary>
        /// this is a public method so the calling code can write to the log as well
        /// </summary>
        /// <param name="message"></param>
        public void WriteToLog(string message)
        {

            // make the directory if it isnt there
            if (!Directory.Exists(this.LogPath))
            { Directory.CreateDirectory(this.LogPath); }

            // add date/time to the front of the message
            message = System.DateTime.Now.ToDateTimeString() + " " + message;

            // send the message through the handler
            StatusMessage(message);

            TextWriter tw = System.IO.File.AppendText(this.LogFilePath);
            tw.WriteLine(message);
            tw.Flush();
            tw.Close();
        }





    }
}
