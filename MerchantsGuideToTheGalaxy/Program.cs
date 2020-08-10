using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToTheGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Galaxy!");
 

            
            bool continueState = true;
            string currentLine;
            //step 1: load file
            FileReader inputLoader = new FileReader();
            
            //step 2: for each line in file, deduce type and then process
            while (continueState = true)
            {
                currentLine = inputLoader.ReadLine();

                if (currentLine == null)
                    continueState = false;
                else
                    Console.WriteLine(currentLine);
            }
            Console.ReadLine();
        }
    }
}
