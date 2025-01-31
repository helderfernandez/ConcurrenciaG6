namespace Proyect1.Presentacion
{
    partial class FrmMatrizEntero
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
            this.btnDimensionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFila = new System.Windows.Forms.TextBox();
            this.txbColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwMatriz = new System.Windows.Forms.DataGridView();
            this.btnContarPrimos = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.Location = new System.Drawing.Point(363, 54);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(148, 23);
            this.btnDimensionar.TabIndex = 0;
            this.btnDimensionar.Text = "Dimensional";
            this.btnDimensionar.UseVisualStyleBackColor = true;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca";
            // 
            // txbFila
            // 
            this.txbFila.Location = new System.Drawing.Point(122, 55);
            this.txbFila.Name = "txbFila";
            this.txbFila.Size = new System.Drawing.Size(100, 22);
            this.txbFila.TabIndex = 2;
            // 
            // txbColumna
            // 
            this.txbColumna.Location = new System.Drawing.Point(239, 54);
            this.txbColumna.Name = "txbColumna";
            this.txbColumna.Size = new System.Drawing.Size(100, 22);
            this.txbColumna.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Columna";
            // 
            // dgwMatriz
            // 
            this.dgwMatriz.AllowUserToAddRows = false;
            this.dgwMatriz.AllowUserToDeleteRows = false;
            this.dgwMatriz.AllowUserToResizeColumns = false;
            this.dgwMatriz.AllowUserToResizeRows = false;
            this.dgwMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatriz.Location = new System.Drawing.Point(40, 95);
            this.dgwMatriz.Name = "dgwMatriz";
            this.dgwMatriz.RowHeadersWidth = 51;
            this.dgwMatriz.RowTemplate.Height = 24;
            this.dgwMatriz.Size = new System.Drawing.Size(611, 150);
            this.dgwMatriz.TabIndex = 6;
            // 
            // btnContarPrimos
            // 
            this.btnContarPrimos.Location = new System.Drawing.Point(40, 282);
            this.btnContarPrimos.Name = "btnContarPrimos";
            this.btnContarPrimos.Size = new System.Drawing.Size(151, 23);
            this.btnContarPrimos.TabIndex = 7;
            this.btnContarPrimos.Text = "Contar primos";
            this.btnContarPrimos.UseVisualStyleBackColor = true;
            this.btnContarPrimos.Click += new System.EventHandler(this.btnContarPrimos_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(218, 281);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(121, 23);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar matriz";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // FrmMatrizEntero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnContarPrimos);
            this.Controls.Add(this.dgwMatriz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbColumna);
            this.Controls.Add(this.txbFila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDimensionar);
            this.Name = "FrmMatrizEntero";
            this.Text = "FrmMatrizEntero";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFila;
        private System.Windows.Forms.TextBox txbColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwMatriz;
        private System.Windows.Forms.Button btnContarPrimos;
        private System.Windows.Forms.Button btnOrdenar;
    }
}