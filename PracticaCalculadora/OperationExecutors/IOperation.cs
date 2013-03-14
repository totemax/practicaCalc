using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    public interface IOperation
    {
        Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator);
    }
}
