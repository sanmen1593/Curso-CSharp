using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "X"; 
            string o = "O";
            string line;
            for (int j = 1; j <= 8; j++) //8 columns
            {
                line = "";
                for (int i = 1; i <= 8; i++) // 8 rows
                {
                    //Intercalate between X's and O's
                    if (i % 2 == 0)
                    {
                        line += o;
                    }
                    else
                    {
                        line += x;
                    }
                }
                if (j % 2 == 0)
                {
                    //If j is pair, reverse the line, to intercalate lines.
                    char[] StringArray = line.ToCharArray();
                    Array.Reverse(StringArray);
                    line = new string(StringArray);
                }
                Console.WriteLine(line);
            }
            Console.ReadKey(); // Don't close the cmd until a key is pressed
        }
    }
}
