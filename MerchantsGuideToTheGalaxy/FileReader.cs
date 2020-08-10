using System;
using System.IO;

namespace MerchantsGuideToTheGalaxy
{
    internal class FileReader
    {

        
        StreamReader inputReader = new StreamReader("TestInput.txt");
        public FileReader()
        { 
        
        }


        public string ReadLine()
        {
            if (inputReader.EndOfStream != null)
                return inputReader.ReadLine();
            else
            {
                CloseFile();
                return "*";
            }
        }

        public void CloseFile()
        {
            inputReader.Close();
            inputReader = null;
        }
    }
}