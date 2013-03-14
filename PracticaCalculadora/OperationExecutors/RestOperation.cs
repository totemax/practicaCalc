using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    class RestOperation:IOperation
    {
        public Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator)
        {
            return Decimal.Subtract(firstOperator, secondOperator);
        }
    }
}
