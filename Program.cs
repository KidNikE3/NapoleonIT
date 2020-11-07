using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int x = CountDigits(number);
            Console.WriteLine(Palindrome(number, x));
            Console.ReadKey();

        }

        public static bool Palindrome(int number, int number_of_digits)
        {
            int left_number = 0;
            int right_number = 0;
            int number_of_digits_2 = number_of_digits - 1;
            bool res = true;
            for (int i = 0; i < number_of_digits / 2; i++)
            {
                left_number = (int)(number / Math.Pow(10, number_of_digits_2));
                right_number = number % 10;
                if (left_number == right_number)
                {
                    number %= (int)Math.Pow(10, number_of_digits_2);
                    number /= 10;
                    number_of_digits_2 -= 2;
                }
                else
                {
                    return res = false;
                }
            }
            return res;
        }

        public static int CountDigits(int x)
        {
            int i = 0;
            if (x < 0) x *= -1;
            do
            {
                x /= 10;
                i += 1;
            } while (x != 0);
            return i;
        }
    }
}

