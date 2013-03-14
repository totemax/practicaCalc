using PracticaCalculadora.OperationExecutors;
namespace PracticaCalculadora
{
    partial class CalculadoraMain
    {
       

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PracticaCalculadora.OperationExecutors.MulOperation mulOperation1 = new PracticaCalculadora.OperationExecutors.MulOperation();
            PracticaCalculadora.OperationExecutors.DivOperation divOperation1 = new PracticaCalculadora.OperationExecutors.DivOperation();
            PracticaCalculadora.OperationExecutors.RestOperation restOperation1 = new PracticaCalculadora.OperationExecutors.RestOperation();
            PracticaCalculadora.OperationExecutors.SumOperation sumOperation1 = new PracticaCalculadora.OperationExecutors.SumOperation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraMain));
            this.tbCalc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMemZero = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMemRes = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMemLess = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnMemMore = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMemory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCalc
            // 
            this.tbCalc.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCalc.Font = new System.Drawing.Font("Digital-7 Italic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCalc.ForeColor = System.Drawing.Color.Lime;
            this.tbCalc.Location = new System.Drawing.Point(12, -3);
            this.tbCalc.MaxLength = 10;
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.ReadOnly = true;
            this.tbCalc.Size = new System.Drawing.Size(355, 40);
            this.tbCalc.TabIndex = 0;
            this.tbCalc.Text = "0";
            this.tbCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnMemZero);
            this.panel1.Controls.Add(this.btnPercentage);
            this.panel1.Controls.Add(this.btnEquals);
            this.panel1.Controls.Add(this.btnMemRes);
            this.panel1.Controls.Add(this.btnMul);
            this.panel1.Controls.Add(this.btnDiv);
            this.panel1.Controls.Add(this.btnMemLess);
            this.panel1.Controls.Add(this.btnLess);
            this.panel1.Controls.Add(this.btnMore);
            this.panel1.Controls.Add(this.btnMemMore);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.btnComma);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 241);
            this.panel1.TabIndex = 1;
            // 
            // btnMemZero
            // 
            this.btnMemZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemZero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMemZero.Location = new System.Drawing.Point(329, 181);
            this.btnMemZero.Name = "btnMemZero";
            this.btnMemZero.Size = new System.Drawing.Size(40, 40);
            this.btnMemZero.TabIndex = 22;
            this.btnMemZero.Tag = PracticaCalculadora.CalculadoraMain.memOperattions.CLR_MEM;
            this.btnMemZero.Text = "MC";
            this.btnMemZero.UseVisualStyleBackColor = false;
            this.btnMemZero.Click += new System.EventHandler(this.btnsMemory_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPercentage.Location = new System.Drawing.Point(269, 181);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(40, 40);
            this.btnPercentage.TabIndex = 21;
            this.btnPercentage.Tag = "per";
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.Control;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEquals.Location = new System.Drawing.Point(209, 181);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(40, 40);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Tag = "=";
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMemRes
            // 
            this.btnMemRes.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemRes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMemRes.Location = new System.Drawing.Point(329, 123);
            this.btnMemRes.Name = "btnMemRes";
            this.btnMemRes.Size = new System.Drawing.Size(40, 40);
            this.btnMemRes.TabIndex = 19;
            this.btnMemRes.Tag = PracticaCalculadora.CalculadoraMain.memOperattions.SHOW_MEM;
            this.btnMemRes.Text = "MR";
            this.btnMemRes.UseVisualStyleBackColor = false;
            this.btnMemRes.Click += new System.EventHandler(this.btnsMemory_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.Control;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMul.Location = new System.Drawing.Point(269, 123);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(40, 40);
            this.btnMul.TabIndex = 18;
            this.btnMul.Tag = mulOperation1;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDiv.Location = new System.Drawing.Point(209, 123);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 40);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Tag = divOperation1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnMemLess
            // 
            this.btnMemLess.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemLess.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMemLess.Location = new System.Drawing.Point(329, 68);
            this.btnMemLess.Name = "btnMemLess";
            this.btnMemLess.Size = new System.Drawing.Size(40, 40);
            this.btnMemLess.TabIndex = 16;
            this.btnMemLess.Tag = PracticaCalculadora.CalculadoraMain.memOperattions.RES_MEM;
            this.btnMemLess.Text = "M-";
            this.btnMemLess.UseVisualStyleBackColor = false;
            this.btnMemLess.Click += new System.EventHandler(this.btnsMemory_Click);
            // 
            // btnLess
            // 
            this.btnLess.BackColor = System.Drawing.SystemColors.Control;
            this.btnLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLess.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLess.Location = new System.Drawing.Point(269, 68);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(40, 40);
            this.btnLess.TabIndex = 15;
            this.btnLess.Tag = restOperation1;
            this.btnLess.Text = "-";
            this.btnLess.UseVisualStyleBackColor = false;
            this.btnLess.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.SystemColors.Control;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMore.Location = new System.Drawing.Point(209, 68);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(40, 40);
            this.btnMore.TabIndex = 14;
            this.btnMore.Tag = sumOperation1;
            this.btnMore.Text = "+";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnOperations_Click);
            // 
            // btnMemMore
            // 
            this.btnMemMore.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemMore.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMemMore.Location = new System.Drawing.Point(329, 13);
            this.btnMemMore.Name = "btnMemMore";
            this.btnMemMore.Size = new System.Drawing.Size(40, 40);
            this.btnMemMore.TabIndex = 13;
            this.btnMemMore.Tag = PracticaCalculadora.CalculadoraMain.memOperattions.SUM_MEM;
            this.btnMemMore.Text = "M+";
            this.btnMemMore.UseVisualStyleBackColor = false;
            this.btnMemMore.Click += new System.EventHandler(this.btnsMemory_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Control;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnC.Location = new System.Drawing.Point(269, 13);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 40);
            this.btnC.TabIndex = 12;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Control;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCE.Location = new System.Drawing.Point(209, 13);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 40);
            this.btnCE.TabIndex = 11;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.SystemColors.Control;
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnComma.Location = new System.Drawing.Point(141, 181);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(40, 40);
            this.btnComma.TabIndex = 10;
            this.btnComma.Tag = ",";
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnZero.Location = new System.Drawing.Point(14, 181);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(104, 40);
            this.btnZero.TabIndex = 9;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.Control;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnThree.Location = new System.Drawing.Point(141, 123);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(40, 40);
            this.btnThree.TabIndex = 8;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.Control;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTwo.Location = new System.Drawing.Point(78, 123);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(40, 40);
            this.btnTwo.TabIndex = 7;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.Control;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOne.Location = new System.Drawing.Point(14, 123);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(40, 40);
            this.btnOne.TabIndex = 6;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.Control;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSix.Location = new System.Drawing.Point(141, 68);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(40, 40);
            this.btnSix.TabIndex = 5;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.Control;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFive.Location = new System.Drawing.Point(78, 68);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(40, 40);
            this.btnFive.TabIndex = 4;
            this.btnFive.Tag = "5";
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.Control;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFour.Location = new System.Drawing.Point(14, 68);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(40, 40);
            this.btnFour.TabIndex = 3;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.Control;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNine.Location = new System.Drawing.Point(141, 13);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(40, 40);
            this.btnNine.TabIndex = 2;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.Control;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEight.Location = new System.Drawing.Point(78, 13);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(40, 40);
            this.btnEight.TabIndex = 1;
            this.btnEight.Tag = "8";
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.Control;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSeven.Location = new System.Drawing.Point(14, 13);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(40, 40);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbCalc);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 37);
            this.panel2.TabIndex = 2;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Enabled = false;
            this.lblMemory.Location = new System.Drawing.Point(12, 53);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(16, 13);
            this.lblMemory.TabIndex = 3;
            this.lblMemory.Text = "M";
            // 
            // CalculadoraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 329);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculadoraMain";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.CalculadoraMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCalc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMemZero;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMemRes;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMemLess;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnMemMore;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMemory;
    }
}