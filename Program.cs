using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            if (input != "4")
            {
                static void PerformOperation(string operationName, Func<int, int, int> operation)
                {
                    Console.WriteLine($"Enter 2 integers to {operationName}");
                    var number1 = Console.ReadLine();
                    var number2 = Console.ReadLine();

                    if (int.TryParse(number1, out int num1) && int.TryParse(number2, out int num2))
                    {
                        Console.Write($"{number1} {operationName} {number2} = ");
                        Console.Write(operation(num1, num2));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                }
                switch (input)
                {
                    case "1":
                        PerformOperation("add", calculator.Add);
                        break;
                    case "2":
                        PerformOperation("subtract", calculator.Subtract);
                        break;
                    case "3":
                        PerformOperation("multiply", calculator.Multiply);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter 2 integers to divide");
                var divideNumber1 = Console.ReadLine();
                var divideNumber2 = Console.ReadLine();

                if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                {
                    Console.Write($"{divideNumber1} / {divideNumber2} = ");
                    Console.Write(calculator.Divide(divNumOne, divNumTwo));
                }
                else
                {
                    Console.WriteLine("One or more of the numbers is not an int");
                }

            }
        }
    }

}
