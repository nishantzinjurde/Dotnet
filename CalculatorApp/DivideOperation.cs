namespace CalculatorApp
{
    public class DivideOperation : IOperation
    {
        public double Execute(double operand1, double operand2)
        {
            if (operand2 == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return operand1 / operand2;
        }
    }
}
