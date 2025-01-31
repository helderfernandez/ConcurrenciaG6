namespace Proyect1.Presentacion
{
    partial class frmEnteros
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
            this.btnInvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnCapicua = new System.Windows.Forms.Button();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(31, 94);
            this.btnInvertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(91, 22);
            this.btnInvertir.TabIndex = 0;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca un número ";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(196, 37);
            this.txbNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(137, 22);
            this.txbNumero.TabIndex = 2;
            // 
            // btnCapicua
            // 
            this.btnCapicua.Location = new System.Drawing.Point(141, 92);
            this.btnCapicua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapicua.Name = "btnCapicua";
            this.btnCapicua.Size = new System.Drawing.Size(122, 25);
            this.btnCapicua.TabIndex = 3;
            this.btnCapicua.Text = "Capicua";
            this.btnCapicua.UseVisualStyleBackColor = true;
            this.btnCapicua.Click += new System.EventHandler(this.btnCapicua_Click);
            // 
            // btnPrimo
            // 
            this.btnPrimo.Location = new System.Drawing.Point(292, 92);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(75, 23);
            this.btnPrimo.TabIndex = 4;
            this.btnPrimo.Text = "Primo";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // frmEnteros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 154);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.btnCapicua);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvertir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEnteros";
            this.Text = "Trabajando con números enteros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnCapicua;
        private System.Windows.Forms.Button btnPrimo;
    }
}