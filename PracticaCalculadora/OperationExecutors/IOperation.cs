using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.OperationExecutors
{
    /**
     * Authors: arodrigo & jjorge
     * Summary: Interfaz que define los metodos basicos de las clases que realizan las operaciones aritmeticas.
     **/
    public interface IOperation
    {
        /*
         * Operación común para todas las operaciones aritméticas. Implementa la resolucion de los calculos.
         */
        Decimal resolveOperation(Decimal firstOperator, Decimal secondOperator);
    }
}
