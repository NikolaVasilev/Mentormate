using System;
using static Solution02.Validations;

namespace Solution02
{
    public class Run
    {
        static void Main()
        {

            var n = int.Parse(Console.ReadLine());


            while (!IsInputCorrect(n))
            {
                Console.WriteLine("Input must be number in range 2 - 10000 and must be odd");
                n = int.Parse(Console.ReadLine());
            }

            //print
            Print(n);

        }

        private static void Print(int n)
        {

            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n + i * 2; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < n - i * 2; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n + i * 2; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < n * 2 - i * 2; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n + i * 2; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < n - i * 2; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n + i * 2; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < n / 2 - i; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < 1+i *2 ; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n + (n - i * 2 - 1); j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < i*2 + 1; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < (n / 2 - i) *2; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < 1 + i*2; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n + (n - i * 2) - 1; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < i + 1 + i; j++)
                {
                    Console.Write('-');
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < n / 2 - i; j++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }


    }
}
