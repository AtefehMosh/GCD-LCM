using System;

namespace GCD_LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The GCD of {0} and {1} is : {2}", num1, num2, GCD(num1, num2));
            LCM(num1, num2);
        }
    
        private static int GCD(int x, int y)
        {
            int remainder = 0;
            while (y != 0)
            {
                remainder = x % y;
                x = y;
                y = remainder;
            }
            return x;
        }
        private static void LCM(int x, int y)
        {
            int result = (x * y) / GCD(x, y);
            Console.WriteLine("The LCM of {0} and {1} is : {2}", x, y, result);
        }

    }

}



