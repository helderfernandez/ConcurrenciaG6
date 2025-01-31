namespace Proyect1.Presentacion
{
    partial class frmVector
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
            this.txbn = new System.Windows.Forms.TextBox();
            this.dgwVector = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnContarPrimos = new System.Windows.Forms.Button();
            this.btnInvertirVector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.Location = new System.Drawing.Point(264, 41);
            this.btnDimensionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(123, 28);
            this.btnDimensionar.TabIndex = 0;
            this.btnDimensionar.Text = "Dimensionar";
            this.btnDimensionar.UseVisualStyleBackColor = true;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca n";
            // 
            // txbn
            // 
            this.txbn.Location = new System.Drawing.Point(156, 44);
            this.txbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbn.Name = "txbn";
            this.txbn.Size = new System.Drawing.Size(89, 22);
            this.txbn.TabIndex = 2;
            // 
            // dgwVector
            // 
            this.dgwVector.AllowUserToAddRows = false;
            this.dgwVector.AllowUserToDeleteRows = false;
            this.dgwVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVector.Location = new System.Drawing.Point(50, 94);
            this.dgwVector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwVector.Name = "dgwVector";
            this.dgwVector.RowHeadersWidth = 62;
            this.dgwVector.RowTemplate.Height = 28;
            this.dgwVector.Size = new System.Drawing.Size(651, 120);
            this.dgwVector.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(50, 250);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(140, 30);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnContarPrimos
            // 
            this.btnContarPrimos.Location = new System.Drawing.Point(207, 250);
            this.btnContarPrimos.Name = "btnContarPrimos";
            this.btnContarPrimos.Size = new System.Drawing.Size(123, 29);
            this.btnContarPrimos.TabIndex = 5;
            this.btnContarPrimos.Text = "Contar primos";
            this.btnContarPrimos.UseVisualStyleBackColor = true;
            this.btnContarPrimos.Click += new System.EventHandler(this.btnContarPrimos_Click);
            // 
            // btnInvertirVector
            // 
            this.btnInvertirVector.Location = new System.Drawing.Point(348, 250);
            this.btnInvertirVector.Name = "btnInvertirVector";
            this.btnInvertirVector.Size = new System.Drawing.Size(140, 30);
            this.btnInvertirVector.TabIndex = 6;
            this.btnInvertirVector.Text = "Invertir Vector";
            this.btnInvertirVector.UseVisualStyleBackColor = true;
            this.btnInvertirVector.Click += new System.EventHandler(this.btnInvertirVector_Click);
            // 
            // frmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnInvertirVector);
            this.Controls.Add(this.btnContarPrimos);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dgwVector);
            this.Controls.Add(this.txbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDimensionar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVector";
            this.Text = "Trabajando con vectores";
            ((System.ComponentModel.ISupportInitialize)(this.dgwVector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbn;
        private System.Windows.Forms.DataGridView dgwVector;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnContarPrimos;
        private System.Windows.Forms.Button btnInvertirVector;
    }
}