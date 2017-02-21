using System;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Library
{
    public class Engine
    {
        /// <summary>
        /// Gets a value that tells whether dirPath is a valid path
        /// </summary>
        /// <param name="dirPath"></param>
        /// <returns></returns>
        /// 
        public static bool IsValidPath(string dirPath)
        {
            string result;
            return CheckPath(dirPath, out result);
        }

        /// <summary>
        /// Returns absolute path for dirPath (user defined) string. A
        /// return value will indicate if the path is valid or not.
        /// </summary>
        /// <param name="dirPath"></param> User specified path
        /// <param name="result"></param> 
        /// <returns>true</returns> if path is correct, otherwise false
        /// 
        public static bool CheckPath(string dirPath, out string result)
        {
            result = String.Empty;
            if (String.IsNullOrWhiteSpace(dirPath))
            {
                return false;
            }
            bool status = false;

            try
            {
                result = Path.GetFullPath(dirPath);
                status = true;
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Bad Arguments");
            }

            catch (SecurityException)
            {
                MessageBox.Show("File is read only.");
            }

            catch (NotSupportedException)
            {
                MessageBox.Show("Not supported.");
            }

            catch (PathTooLongException)
            {
                MessageBox.Show("Path is too long.");
            }
            return status;
        }


        //Find the files and directories that have changed
        public static void FileWatcher()
        {

            FileSystemWatcher fsw = new FileSystemWatcher();
            //fsw.Path = dirPath;
        }


        /*  DEPRECATED
        
        public bool CheckPath2(string userPath)
        {
            char[] invalidPathChars;
            int invalidCharPos = -1;
            bool endOfPath = false;
            bool invalidPath = false;
        
            while (!endOfPath)
            {
              invalidPathChars = Path.GetInvalidPathChars();
              invalidCharPos = invalidCharPos + 1;
        
                if (invalidCharPos == -1)
                {
                    endOfPath = true;
                }
                else
                {
                    invalidPath = true;
                    Console.WriteLine("Invalid path. Please double check it!");
        
                    if (invalidCharPos >= userPath.Length - 1)
                    {
                        endOfPath = true;
                    }
                    else
                    {
                        invalidCharPos++;
                    }
                }
            }
            return (invalidPath);
        }
        */
    }
}
