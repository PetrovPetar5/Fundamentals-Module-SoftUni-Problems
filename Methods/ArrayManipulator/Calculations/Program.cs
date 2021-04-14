namespace Calculations
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            double firstInput = double.Parse(Console.ReadLine());
            double secondInput = double.Parse(Console.ReadLine());
            if (command == "add")
            {
                AddAndPrintInputs(firstInput, secondInput);
            }
            else if (command == "multiply")
            {
                MultiplyAndPrintInputs(firstInput, secondInput);
            }
            else if (command == "subtract")
            {
                SubtractAndPrintInputs(firstInput, secondInput);
            }
            else
            {
                DivideAndPrintInputs(firstInput, secondInput);
            }
        }
        static void AddAndPrintInputs(double firstInput, double secondInput)
        {
            Console.WriteLine(firstInput + secondInput);
        }

        static void MultiplyAndPrintInputs(double firstInput, double secondInput)
        {
            Console.WriteLine(firstInput * secondInput);
        }

        static void SubtractAndPrintInputs(double firstInput, double secondInput)
        {
            Console.WriteLine(firstInput - secondInput);
        }

        static void DivideAndPrintInputs(double firstInput, double secondInput)
        {
            Console.WriteLine(firstInput / secondInput);
        }
    }
}
