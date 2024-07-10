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
            double number1, number2;
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
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                case '!':
                    break;
                default:
                    break;
            }
        }

        double Cong(double num1, double num2)
        {
            return 0;
        }

        double Tru(double num1, double num2)
        {
            return 0;
        }

        double Nhan(double num1, double num2)
        {
            return 0;
        }

        double Chia(double num1, double num2)
        {
            return 0;
        }

        double GiaiThua(double num1, double num2)
        {
            return 0;
        }
    }
}
