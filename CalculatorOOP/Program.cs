using CalculatorOOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Calculator\n2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    double firstNumber, secondNumber;

                    Console.Write("Your name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the first number :");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                key:
                    Console.Write("Enter the operation like +,-,*, / , % or ^:");
                    string function = Console.ReadLine();
                    while (true)
                    {

                        if (function == "+" || function == "-" || function == "*" || function == "/" || function == "^")
                        {
                            break;
                        }
                        else
                        {
                            goto key;
                        }
                    }
                    Console.Write("Enter the second number :");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Result : ");



                    if (function == "prc")
                    {
                        AdvancedCalculate advancedCalculate = new AdvancedCalculate(name, firstNumber, function, secondNumber);
                        advancedCalculate.CalculateAllFunctions();
                    }
                    else if (function == "^")
                    {
                        CalculateDegreeOfNumber calculateDegreeOfNumber = new CalculateDegreeOfNumber(name, firstNumber, function, secondNumber);
                        calculateDegreeOfNumber.CalculateAllFunctions();
                    }
                    else
                    {
                        ICalculate calculate = new Calculate(name, firstNumber, function, secondNumber);
                        calculate.CalculateAllFunctions();
                    }
                }
                else
                {
                    break;
                }

            }




            Console.ReadKey();
        }
    }
}
