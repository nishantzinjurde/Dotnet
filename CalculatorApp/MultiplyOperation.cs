namespace CalculatorApp
{
    public class MultiplyOperation : IOperation
    {
        public double Execute(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }
}
