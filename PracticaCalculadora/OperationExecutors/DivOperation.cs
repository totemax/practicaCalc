using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    /**
     * Authors: arodrigo & jjorge
     * Summary: Clase de implementacion de la operacion de division.
     * */
    class DivOperation:IOperation
    {
        /**
         * Resolucion de la operacion de division
         * */
        public Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator)
        {
            return Decimal.Divide(firstOperator, secondOperator);
        }
    }
}
