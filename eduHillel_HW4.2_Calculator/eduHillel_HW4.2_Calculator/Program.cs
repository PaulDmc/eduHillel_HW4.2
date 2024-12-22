using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Hillel_HW42_Demchenko
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int resultOperation = 0;
            char operation;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the first number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation:");
                operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '+':
                        resultOperation = firstNumber + secondNumber;
                        break;
                    case '-':
                        resultOperation = firstNumber - secondNumber;
                        break;
                    case '*':
                        resultOperation = firstNumber * secondNumber;
                        break;
                    case '/':
                        resultOperation = firstNumber / secondNumber;
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;


                }
                Console.WriteLine($"Result: {resultOperation}");
                Console.WriteLine("Press any key to continue or close the console");
                Console.ReadKey();


            }

        }

    }
}