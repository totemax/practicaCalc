using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    class SumOperation : IOperation
    {
        public Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator)
        {
            return Decimal.Add(firstOperator, secondOperator);
        }
    }
}
