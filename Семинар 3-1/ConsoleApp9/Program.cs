using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Calculator
    {
        public delegate int MathOperation(int a, int b);

        static Dictionary<string, MathOperation> operations;

        static Calculator()
        {
            MathOperation plus = (x, y) => x + y;
            operations = new Dictionary<string, MathOperation>
            {
                ["+"] = plus,
                ["-"] = (x, y) => x - y,
                ["*"] = (x, y) => x * y,
                ["/"] = (x, y) => x / y,
                ["gcd"] = (x, y) =>
                {
                    while (x != 0 && y != 0)
                    {
                        if (x > y)
                            x %= y;
                        else
                            y %= x;
                    }

                    return x == 0 ? y : x;
                },
            };
        }

        public static int Calculate(string operation, int a, int b)
        {
            if (operations.ContainsKey(operation))
            {
                return operations[operation](a, b);
            }
            else
            {
                throw new ArgumentException("Invalid operator");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string[] arguments = expression.Split(' ');

            int operandA = int.Parse(arguments[0]);
            string operatorExpr = arguments[1];
            int operandB = int.Parse(arguments[2]);

            Console.WriteLine(Calculator.Calculate(operatorExpr, operandA, operandB));
        }
    }
}
