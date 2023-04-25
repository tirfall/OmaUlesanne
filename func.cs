using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmaUlesanne
{
    public class func
    {
        public static string Massiv(int[,] mas)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static string Leianumb(int number)
        {

        }
    }
}
