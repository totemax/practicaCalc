using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PracticaCalculadora.OperationExecutors;

namespace PracticaCalculadora
{
    public partial class CalculadoraMain : Form
    {
         /**
         * Enumeration comprobar las operaciones en memoria que se van a realizar
         */
        public enum memOperattions
        {
            SUM_MEM = 0,
            RES_MEM = 1,
            CLR_MEM = 2,
            SHOW_MEM = 3
        }

        //Variable que almacena la operación que se ha invocado para poder resolverla posteriormente
        public IOperation actualOperation = null;
        //Variable que almacen el primer termino de la operacion
        public Decimal firstTerm = 0;
        //Flag para comprobar si el valor mostrado en el display es antiguo para borrarlo cuando se escribe
        private bool isOldValue = true;
        //Variable que almacena el contenido de la memoria de la calculadora
        private Decimal memory = 0;

        public CalculadoraMain()
        {
            InitializeComponent();

        }

        private void CalculadoraMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnEquals;
        }

        /**
         * Evento que controla el pulsado de los botones de operaciones aritmeticas
         * */
        private void btnOperations_Click(Object sender, EventArgs e)
        {
            try
            {
                if (actualOperation != null)
                {
                    Decimal actualTerm = Decimal.Parse(tbCalc.Text);
                    this.firstTerm = actualOperation.resolveOperation(this.firstTerm, actualTerm);
                }
                else firstTerm = Decimal.Parse(tbCalc.Text);
                //Realizamos el cast del sender para poder acceder a sus atributos
                Button btnOperation = (Button)sender;
                //En el tag del button almacenamos la operacion que se va a realizar en cada boton
                //de esta forma podemos usar la misma funcion para todas las operaciones
                actualOperation = (IOperation)btnOperation.Tag;
                parseToDisplay(this.firstTerm);
            }
            catch (Exception)
            {
                //Controlamos los posibles errores (errores de parseo, etc..)
                this.tbCalc.Text = "Err";
                this.firstTerm = 0;
                this.isOldValue = true;
                actualOperation = null;
            }
        }

        /**
         * Evento que controla los botones de números y los escribe en pantalla.
         * */
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btnNum =  (Button) sender;
            //Si el valor es antiguo borramos y escribimos encima
            if (isOldValue)
            {
                tbCalc.Text = btnNum.Text;
                isOldValue = false;
            }
            //en caso contrario concatenamos
            else tbCalc.Text += btnNum.Text;
        }

        /**
         * Evento que controla el boton "=" para realizar las operaciones.
         * */
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (actualOperation != null)
                {
                    Decimal actualTerm = Decimal.Parse(tbCalc.Text);
                    this.firstTerm = actualOperation.resolveOperation(this.firstTerm, actualTerm);
                    parseToDisplay(this.firstTerm);
                }
            }
            //Controlamos los errores aritmeticos posibles al realizar las operaciones.
            catch (ArithmeticException)
            {
                this.tbCalc.Text = "err";
            }
            finally
            {
                this.actualOperation = null;
            }
        }

        /**
         * Evento del boton que limpia la calculadora y la pantalla.
         * */
        private void btnC_Click(object sender, EventArgs e)
        {
            this.actualOperation = null;
            this.firstTerm = 0;
            this.tbCalc.Text = "0";
            this.isOldValue = true;
        }

        /**
         * Evento del boton que limpia la pantalla.
         * */
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbCalc.Text = "0";
            this.isOldValue = true;
        }

        /**
         * Evento del boton "%". 
         * */
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                if (actualOperation != null)
                {
                    Decimal actualTerm = Decimal.Parse(tbCalc.Text);
                    //Realizamos el procentage del primer y segundo operador.
                    this.firstTerm = Decimal.Divide(Decimal.Multiply(actualTerm, firstTerm), 100);
                    parseToDisplay(firstTerm);
                }
            }
            catch (Exception)
            {
                this.tbCalc.Text = "err";
            }
            finally
            {
                this.actualOperation = null;
            }
        }

        /**
         * Funcion que realiza la salida por pantalla de los resultados.
         * */
        private void parseToDisplay(decimal dec)
        {
            String tDec = Decimal.Truncate(dec).ToString();
            //El numero total de digitos es 10, asique mostramos tantos decimales como 10-parte entera
            int numDigits = 10 - tDec.Length;
            //realizamos un redondeo para que los digitos se ajusten a la pantalla
            tbCalc.Text = Decimal.Round(dec, numDigits, MidpointRounding.ToEven).ToString();
            this.isOldValue = true;
        }


        /*
         * Evento que controla las operaciones de memoria.
         * */
        private void btnsMemory_Click(object sender, EventArgs e)
        {
            try
            {
                Button send = (Button)sender;
                //Comprobamos cual de las operaciones del enumerador estamos invocando
                //Dicha informacion la almacenamos previamente en el tag del boton
                switch ((memOperattions)send.Tag)
                {
                    case memOperattions.SHOW_MEM:
                        this.isOldValue = true;
                        this.actualOperation = null;
                        parseToDisplay(memory);
                        break;
                    case memOperattions.CLR_MEM:
                        memory = 0;
                        lblMemory.Enabled = false;
                        break;
                    case memOperattions.SUM_MEM:
                        this.isOldValue = true;
                        memory = Decimal.Add(memory, Decimal.Parse(tbCalc.Text));
                        lblMemory.Enabled = true;
                        break;
                    case memOperattions.RES_MEM:
                        this.isOldValue = true;
                        memory = Decimal.Subtract(memory, Decimal.Parse(tbCalc.Text));
                        lblMemory.Enabled = true;
                        break;
                }
            }
            catch (Exception)
            {
                this.tbCalc.Text = "err";
            }
        }
    }
}
