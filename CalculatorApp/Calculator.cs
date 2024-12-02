namespace CalculatorApp
{
    public class Calculator
    {
        public double PerformOperation(IOperation operation, double operand1, double operand2)
        {
            if (operation == null)
                throw new ArgumentNullException(nameof(operation), "Operation cannot be null");

            return operation.Execute(operand1, operand2);
        }
    }
}
