using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmaUlesanne
{
    public class Menu
    {
        public static void mainmenu(int valik, int x, int[,] massiiv)
        {
            switch (valik)
            {
                case 1:
                    func.Massiv(massiiv);
                    break;
                case 2:
                    Console.WriteLine("Sisesta number:");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(func.Leianumb(number));
                    break;
                case 3:
                    x++;
                    break;
                default:
                    Console.WriteLine("Vale number");
                    break;
            }
        }

    }
}
