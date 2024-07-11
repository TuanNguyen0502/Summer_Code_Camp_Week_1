using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double number1, number2, result = 0;
            char calculation;

            Console.WriteLine("Enter the 1st number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the calculation: ");
            Console.WriteLine("+ for addition\t\t- for subtraction\n* for multiplication\t/ for division\n! for factorial");
            calculation = Console.ReadKey().KeyChar;

            Console.WriteLine("\n\nEnter the 2nd number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            switch (calculation)
            {
                case '+':
                    result = Cong(number1, number2);
                    break;
                case '-':
                    result = Tru(number1, number2);
                    break;
                case '*':
                    result = Nhan(number1, number2);
                    break;
                case '/':
                    result = Chia(number1, number2);
                    break;
                case '!':
                    result = GiaiThua(number1, number2);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"\n\nResult: {result}");
        }

        static double Cong(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Tru(double num1, double num2)
        {
            return 0;
        }

        static double Nhan(double num1, double num2)
        {
            return 0;
        }

        static double Chia(double num1, double num2)
        {
            return 0;
        }

        static double GiaiThua(double num1, double num2)
        {
            return 0;
        }
    }
}
