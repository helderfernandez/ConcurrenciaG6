namespace Proyect1.Presentacion
{
    partial class frmOperacionesMatriz
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
            this.dgwMatriz1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbColumna = new System.Windows.Forms.TextBox();
            this.txbFila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDimensionar = new System.Windows.Forms.Button();
            this.dgwMatriz2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwMatrizResultado = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPERACIONESCONMATRIZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrizResultado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMatriz1
            // 
            this.dgwMatriz1.AllowUserToAddRows = false;
            this.dgwMatriz1.AllowUserToDeleteRows = false;
            this.dgwMatriz1.AllowUserToResizeColumns = false;
            this.dgwMatriz1.AllowUserToResizeRows = false;
            this.dgwMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatriz1.Location = new System.Drawing.Point(22, 128);
            this.dgwMatriz1.Name = "dgwMatriz1";
            this.dgwMatriz1.RowHeadersWidth = 51;
            this.dgwMatriz1.RowTemplate.Height = 24;
            this.dgwMatriz1.Size = new System.Drawing.Size(489, 150);
            this.dgwMatriz1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Columna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fila";
            // 
            // txbColumna
            // 
            this.txbColumna.Location = new System.Drawing.Point(221, 87);
            this.txbColumna.Name = "txbColumna";
            this.txbColumna.Size = new System.Drawing.Size(100, 22);
            this.txbColumna.TabIndex = 10;
            // 
            // txbFila
            // 
            this.txbFila.Location = new System.Drawing.Point(104, 88);
            this.txbFila.Name = "txbFila";
            this.txbFila.Size = new System.Drawing.Size(100, 22);
            this.txbFila.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduzca";
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.Location = new System.Drawing.Point(345, 87);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(148, 23);
            this.btnDimensionar.TabIndex = 7;
            this.btnDimensionar.Text = "Dimensional";
            this.btnDimensionar.UseVisualStyleBackColor = true;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // dgwMatriz2
            // 
            this.dgwMatriz2.AllowUserToAddRows = false;
            this.dgwMatriz2.AllowUserToDeleteRows = false;
            this.dgwMatriz2.AllowUserToResizeColumns = false;
            this.dgwMatriz2.AllowUserToResizeRows = false;
            this.dgwMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatriz2.Location = new System.Drawing.Point(562, 128);
            this.dgwMatriz2.Name = "dgwMatriz2";
            this.dgwMatriz2.RowHeadersWidth = 51;
            this.dgwMatriz2.RowTemplate.Height = 24;
            this.dgwMatriz2.Size = new System.Drawing.Size(489, 150);
            this.dgwMatriz2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Matriz #1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Matriz #2";
            // 
            // dgwMatrizResultado
            // 
            this.dgwMatrizResultado.AllowUserToAddRows = false;
            this.dgwMatrizResultado.AllowUserToDeleteRows = false;
            this.dgwMatrizResultado.AllowUserToResizeColumns = false;
            this.dgwMatrizResultado.AllowUserToResizeRows = false;
            this.dgwMatrizResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatrizResultado.Location = new System.Drawing.Point(294, 323);
            this.dgwMatrizResultado.Name = "dgwMatrizResultado";
            this.dgwMatrizResultado.RowHeadersWidth = 51;
            this.dgwMatrizResultado.RowTemplate.Height = 24;
            this.dgwMatrizResultado.Size = new System.Drawing.Size(489, 150);
            this.dgwMatrizResultado.TabIndex = 23;
            this.dgwMatrizResultado.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Matriz resultado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPERACIONESCONMATRIZToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1334, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPERACIONESCONMATRIZToolStripMenuItem
            // 
            this.oPERACIONESCONMATRIZToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.oPERACIONESCONMATRIZToolStripMenuItem.Name = "oPERACIONESCONMATRIZToolStripMenuItem";
            this.oPERACIONESCONMATRIZToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.oPERACIONESCONMATRIZToolStripMenuItem.Text = "Operaciones con matriz";
            this.oPERACIONESCONMATRIZToolStripMenuItem.Click += new System.EventHandler(this.oPERACIONESCONMATRIZToolStripMenuItem_Click);
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmOperacionesMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgwMatrizResultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwMatriz2);
            this.Controls.Add(this.dgwMatriz1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbColumna);
            this.Controls.Add(this.txbFila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDimensionar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOperacionesMatriz";
            this.Text = "OPERACIONES CON MATRIZ";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrizResultado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMatriz1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbColumna;
        private System.Windows.Forms.TextBox txbFila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.DataGridView dgwMatriz2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwMatrizResultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPERACIONESCONMATRIZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}