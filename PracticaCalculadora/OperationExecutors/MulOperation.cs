using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    class MulOperation:IOperation
    {
        public Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator)
        {
            return Decimal.Multiply(firstOperator, secondOperator);
        }
    }
}
