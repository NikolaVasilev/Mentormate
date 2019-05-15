using System;
using static Solution01.Validations;
using System.IO;
using System.Text;

namespace Solution01
{
    public class Run
    {
        static void Main()
        {
            Console.WriteLine("Please insert odd number in range 2-10000, if number is bigger than 21 output will be saved in text file in solution directory:");
            var n = int.Parse(Console.ReadLine());


            while (!IsInputCorrect(n))
            {
                Console.WriteLine("Input must be number in range 2 - 10000 and must be odd");
                n = int.Parse(Console.ReadLine());
            }

            Print(n);

        }

        private static void Print(int n)
        {
            var sb = new StringBuilder();
            for (int i = 0; i <= n / 2; i++)
            {
                sb.AppendLine(new string('-', n - i)
                                  + new string('*', n + i * 2)
                                  + new string('-', n - i * 2)
                                  + new string('*', n + i * 2)
                                  + new string('-', n * 2 - i * 2)
                                  + new string('*', n + i * 2)
                                  + new string('-', n - i * 2)
                                  + new string('*', n + i * 2)
                                  + new string('-', n - i));
            }
            for (int i = 0; i <= n / 2; i++)
            {
                sb.AppendLine(new string('-', n / 2 - i)
                                  + new string('*', n)
                                  + new string('-', 1 + i * 2)
                                  + new string('*', n + (n - i * 2) - 1)
                                  + new string('-', i * 2 + 1)
                                  + new string('*', n)
                                  + new string('-', (n / 2 - i) * 2)
                                  + new string('*', n) 
                                  + new string('-', 1 + i * 2)
                                  + new string('*', n + (n - i * 2) - 1) 
                                  + new string('-', i * 2 + 1)
                                  + new string('*', n)
                                  + new string('-', (n / 2 - i)));
            }

            Console.WriteLine(sb.ToString().Trim());

            if (n > 21)
            {
                string path = "../../../Output.txt";
                File.WriteAllText(path, sb.ToString().Trim());               
            }
           
        }       
    }
}
