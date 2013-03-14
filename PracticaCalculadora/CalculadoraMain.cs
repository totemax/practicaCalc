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
         * Enumeration para las operaciones de uso de memoria
         */
        public enum memOperattions
        {
            SUM_MEM = 0,
            RES_MEM = 1,
            CLR_MEM = 2,
            SHOW_MEM = 3
        }

     

        private IDictionary<String, IOperation> operationsSet = new Dictionary<String, IOperation>();
        public IOperation actualOperation = null;
        public Decimal firstTerm = 0;
        private bool isOldValue = true;
        private Decimal memory = 0;

        public CalculadoraMain()
        {
            InitializeComponent();

        }

        private void CalculadoraMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnEquals;
        }

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
                Button btnOperation = (Button)sender;
                actualOperation = (IOperation)btnOperation.Tag;
                parseToDisplay(this.firstTerm);
                isOldValue = true;
            }
            catch (Exception)
            {
                this.tbCalc.Text = "Err";
                this.firstTerm = 0;
                this.isOldValue = true;
                actualOperation = null;
            }
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btnNum =  (Button) sender;
            if (isOldValue)
            {
                tbCalc.Text = btnNum.Text;
                isOldValue = false;
            }
            else tbCalc.Text += btnNum.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (actualOperation != null)
                {
                    Decimal actualTerm = Decimal.Parse(tbCalc.Text);
                    this.firstTerm = actualOperation.resolveOperation(this.firstTerm, actualTerm);
                }
                parseToDisplay(this.firstTerm);
            }
            catch (ArithmeticException)
            {
                this.tbCalc.Text = "err";
            }
            finally
            {
                this.isOldValue = true;
                this.actualOperation = null;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.actualOperation = null;
            this.firstTerm = 0;
            this.tbCalc.Text = "0";
            this.isOldValue = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbCalc.Text = "0";
            this.isOldValue = true;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            try
            {

                if (actualOperation != null)
                {
                    Decimal actualTerm = Decimal.Parse(tbCalc.Text);
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
                this.isOldValue = true;
                this.actualOperation = null;
            }
        }

        private void parseToDisplay(decimal dec)
        {
            String tDec = Decimal.Truncate(dec).ToString();
            int numDigits = 10 - tDec.Length;
            tbCalc.Text = Decimal.Round(dec, numDigits, MidpointRounding.ToEven).ToString();
        }



        private void btnsMemory_Click(object sender, EventArgs e)
        {
            try
            {
                Button send = (Button)sender;
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
