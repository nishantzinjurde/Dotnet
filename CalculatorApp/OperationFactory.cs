using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class OperationFactory
    {
        private readonly Dictionary<string, IOperation> _operationMap;

        public OperationFactory()
        {
            _operationMap = new Dictionary<string, IOperation>
            {
                { "+", new AddOperation() },
                { "-", new SubtractOperation() },
                { "*", new MultiplyOperation() },
                { "/", new DivideOperation() }
            };
        }

        public IOperation GetOperation(string operationSymbol)
        {
            if (_operationMap.TryGetValue(operationSymbol, out IOperation operation))
            {
                return operation;
            }

            throw new InvalidOperationException($"Invalid operation symbol: {operationSymbol}");
        }
    }
}
