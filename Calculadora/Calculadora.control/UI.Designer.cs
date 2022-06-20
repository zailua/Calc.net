namespace Calculadora.control
{
    partial class UI
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnZerar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(29, 117);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(29, 167);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(29, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(179, 117);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(179, 167);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(29, 36);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(225, 20);
            this.txtValue.TabIndex = 5;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(179, 220);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(75, 23);
            this.btnZerar.TabIndex = 6;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(29, 326);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(225, 31);
            this.txtResult.TabIndex = 7;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSoma);
            this.Name = "UI";
            this.Size = new System.Drawing.Size(283, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.TextBox txtResult;
    }
}
