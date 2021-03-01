using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePowerOfAnyGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int bNum, pwr;
            int result;
            Console.Write("\n\n Rescursion: Calculate power of any number: \n");
            Console.Write("------------------------------------------------\n");

            Console.Write("Input the base value: ");
            bNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the exponent: ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalcOfPower(bNum,pwr);

            Console.Write("The value of {0} to the power of {1} is: {2} \n\n", bNum,pwr,result);

            Console.ReadKey();
        }
        public static int CalcOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcOfPower(x, y - 1);
        }
    }
}
