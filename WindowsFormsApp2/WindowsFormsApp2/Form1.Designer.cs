namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.rdbTriangulo = new System.Windows.Forms.RadioButton();
            this.rdbQuadrado = new System.Windows.Forms.RadioButton();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura :";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(85, 26);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 2;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(85, 62);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 3;
            // 
            // rdbTriangulo
            // 
            this.rdbTriangulo.AutoSize = true;
            this.rdbTriangulo.Location = new System.Drawing.Point(30, 113);
            this.rdbTriangulo.Name = "rdbTriangulo";
            this.rdbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rdbTriangulo.TabIndex = 4;
            this.rdbTriangulo.TabStop = true;
            this.rdbTriangulo.Text = "Triângulo";
            this.rdbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rdbQuadrado
            // 
            this.rdbQuadrado.AutoSize = true;
            this.rdbQuadrado.Location = new System.Drawing.Point(30, 178);
            this.rdbQuadrado.Name = "rdbQuadrado";
            this.rdbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rdbQuadrado.TabIndex = 5;
            this.rdbQuadrado.TabStop = true;
            this.rdbQuadrado.Text = "Quadrado";
            this.rdbQuadrado.UseVisualStyleBackColor = true;
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Location = new System.Drawing.Point(30, 145);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rdbRetangulo.TabIndex = 6;
            this.rdbRetangulo.TabStop = true;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(30, 218);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(85, 272);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor : ";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(111, 218);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(74, 23);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(149, 145);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(13, 13);
            this.lblAviso.TabIndex = 11;
            this.lblAviso.Text = "0";
            this.lblAviso.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 362);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.rdbRetangulo);
            this.Controls.Add(this.rdbQuadrado);
            this.Controls.Add(this.rdbTriangulo);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.RadioButton rdbTriangulo;
        private System.Windows.Forms.RadioButton rdbQuadrado;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblAviso;
    }
}

