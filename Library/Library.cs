using System;
using System.IO;


namespace Library
{
    public class Library
    {
        //Checks user entered directory path
        public bool CheckPath(string userPath)
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
    }
}
