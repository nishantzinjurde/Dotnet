using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var factory = new OperationFactory(); // Create an instance of the factory

            Console.WriteLine("Enter the first operand:");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operationSymbol = Console.ReadLine();

            Console.WriteLine("Enter the second operand:");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            try
            {
         
                IOperation operation = factory.GetOperation(operationSymbol);

                double result = calculator.PerformOperation(operation, operand1, operand2);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
