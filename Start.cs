using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OmaUlesanne
{
    public class Start
    {
        public static void Main()
        {
            int x = 0;
            int y = 0;
            int[,] massiiv = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    massiiv[i, j] = i+j;
                }
            }
            while (x != 1)
            {
                Console.WriteLine("1 - vaata massiivi\n2 - Leia massiivist number\n3 - Lõpeta programm");
                int valik = int.Parse(Console.ReadLine());
                Menu.mainmenu(valik, x, massiiv);
            }
        }
    }
}
