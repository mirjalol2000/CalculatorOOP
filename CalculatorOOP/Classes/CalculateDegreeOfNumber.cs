using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP.Classes
{
    public class CalculateDegreeOfNumber : Calculate, ICalculateDegreeOfNumber
    {
        History addHistory = new History();

        public CalculateDegreeOfNumber(string name, double firstNumber, string function, double secondNumber)
            : base(name, firstNumber, function, secondNumber)
        {

        }

        public double DegreeOfNumber(double firstNumber, double secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }

        public override void CalculateAllFunctions()
        {
            double result = DegreeOfNumber(this.FirstNumber, this.SecondNumber);
            string operation = $"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}";
            addHistory.AddHistory(operation);
            Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
        }

    }
}
