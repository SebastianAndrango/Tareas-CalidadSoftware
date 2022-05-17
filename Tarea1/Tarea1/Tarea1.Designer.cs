namespace Tarea1
{
    partial class Tarea1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTypeTriangle = new System.Windows.Forms.TextBox();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.lblSemiperimeter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSideA = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.lblSideC = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.grgInputs = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbOutputs.SuspendLayout();
            this.grgInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTypeTriangle
            // 
            this.txtTypeTriangle.Enabled = false;
            this.txtTypeTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeTriangle.Location = new System.Drawing.Point(215, 64);
            this.txtTypeTriangle.Name = "txtTypeTriangle";
            this.txtTypeTriangle.Size = new System.Drawing.Size(101, 20);
            this.txtTypeTriangle.TabIndex = 3;
            this.txtTypeTriangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTypeTriangle_KeyPress);
            // 
            // grbOutputs
            // 
            this.grbOutputs.BackColor = System.Drawing.Color.White;
            this.grbOutputs.Controls.Add(this.txtTypeTriangle);
            this.grbOutputs.Controls.Add(this.lblSemiperimeter);
            this.grbOutputs.Location = new System.Drawing.Point(1, 202);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(419, 143);
            this.grbOutputs.TabIndex = 12;
            this.grbOutputs.TabStop = false;
            // 
            // lblSemiperimeter
            // 
            this.lblSemiperimeter.AutoSize = true;
            this.lblSemiperimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemiperimeter.Location = new System.Drawing.Point(56, 62);
            this.lblSemiperimeter.Name = "lblSemiperimeter";
            this.lblSemiperimeter.Size = new System.Drawing.Size(117, 18);
            this.lblSemiperimeter.TabIndex = 1;
            this.lblSemiperimeter.Text = "Tipo de triángulo";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(298, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideA.Location = new System.Drawing.Point(56, 34);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(63, 18);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Lado \'a\' ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(179, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(60, 28);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(215, 97);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(101, 20);
            this.txtSideC.TabIndex = 5;
            this.txtSideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSideC_KeyPress);
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(215, 67);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(101, 20);
            this.txtSideB.TabIndex = 4;
            this.txtSideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSideB_KeyPress);
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideC.Location = new System.Drawing.Point(56, 97);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(63, 18);
            this.lblSideC.TabIndex = 3;
            this.lblSideC.Text = "Lado \'c\' ";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideB.Location = new System.Drawing.Point(56, 65);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(63, 18);
            this.lblSideB.TabIndex = 2;
            this.lblSideB.Text = "Lado \'b\' ";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(215, 36);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(101, 20);
            this.txtSideA.TabIndex = 1;
            this.txtSideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSideA_KeyPress);
            // 
            // grgInputs
            // 
            this.grgInputs.BackColor = System.Drawing.Color.White;
            this.grgInputs.Controls.Add(this.txtSideC);
            this.grgInputs.Controls.Add(this.txtSideB);
            this.grgInputs.Controls.Add(this.lblSideC);
            this.grgInputs.Controls.Add(this.lblSideB);
            this.grgInputs.Controls.Add(this.txtSideA);
            this.grgInputs.Controls.Add(this.lblSideA);
            this.grgInputs.Location = new System.Drawing.Point(1, -1);
            this.grgInputs.Name = "grgInputs";
            this.grgInputs.Size = new System.Drawing.Size(419, 129);
            this.grgInputs.TabIndex = 10;
            this.grgInputs.TabStop = false;
            // 
            // grbProcess
            // 
            this.grbProcess.BackColor = System.Drawing.Color.White;
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(1, 134);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(419, 72);
            this.grbProcess.TabIndex = 11;
            this.grbProcess.TabStop = false;
            // 
            // Tarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grgInputs);
            this.Controls.Add(this.grbProcess);
            this.Name = "Tarea1";
            this.Text = "Tipo de triángulo";
            this.Load += new System.EventHandler(this.Tarea1_Load);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grgInputs.ResumeLayout(false);
            this.grgInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeTriangle;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblSemiperimeter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.GroupBox grgInputs;
        private System.Windows.Forms.GroupBox grbProcess;
    }
}

