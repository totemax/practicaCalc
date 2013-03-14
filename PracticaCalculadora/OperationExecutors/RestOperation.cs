using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    /**
     * Authors: arodrigo & jjorge
     * Summary: Clase de implementacion de la operacion de resta.
     * */
    class RestOperation:IOperation
    {
        /**
       * Resolucion de la operacion de resta
       * */
        public Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator)
        {
            return Decimal.Subtract(firstOperator, secondOperator);
        }
    }
}
