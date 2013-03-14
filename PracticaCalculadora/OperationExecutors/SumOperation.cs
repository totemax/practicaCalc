using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    /**
     * Authors: arodrigo & jjorge
     * Summary: Clase de implementacion de la operacion de suma.
     * */
    class SumOperation : IOperation
    {
        /**
       * Resolucion de la operacion de suma
       * */
        public Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator)
        {
            return Decimal.Add(firstOperator, secondOperator);
        }
    }
}
