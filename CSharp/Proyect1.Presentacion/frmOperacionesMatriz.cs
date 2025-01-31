using Preyecto1.RN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect1.Presentacion
{
    public partial class frmOperacionesMatriz : Form
    {
        public frmOperacionesMatriz()
        {
            InitializeComponent();
        }
        private void Dimensionar(Int32 Fila, Int32 columnas)
        {
            this.dgwMatriz1.Rows.Clear();
            this.dgwMatriz1.Columns.Clear();

            this.dgwMatriz2.Rows.Clear();
            this.dgwMatriz2.Columns.Clear();

            this.dgwMatrizResultado.Rows.Clear();
            this.dgwMatrizResultado.Columns.Clear();

            for (Int32 i = 0; i <= columnas - 1; i++)            {
                this.dgwMatriz1.Columns.Add(i.ToString(), i.ToString());
                this.dgwMatriz2.Columns.Add(i.ToString(), i.ToString());
                this.dgwMatrizResultado.Columns.Add(i.ToString(), i.ToString());
            }

            for (Int32 i = 0; i <= Fila - 1; i++)
            {
                this.dgwMatriz1.Rows.Add();
                this.dgwMatriz2.Rows.Add();
                this.dgwMatrizResultado.Rows.Add();
            }
        }
        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            this.Dimensionar(Int32.Parse(this.txbFila.Text), Int32.Parse(this.txbColumna.Text));
        }

        private void oPERACIONESCONMATRIZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void CargarMatrices(ref RnMatriz M1, ref RnMatriz M2)
        {

            for (Int32 i = 0; i <= Int32.Parse(this.txbFila.Text) - 1; i++)
            {
                for (Int32 j = 0; j <= Int32.Parse(this.txbColumna.Text) - 1; j++)
                {
                    RNEntero ObjRnEntero = new RNEntero();
                    RNEntero ObjRnEntero1 = new RNEntero();
                    //matriz  M1
                    ObjRnEntero.Num = Int32.Parse(this.dgwMatriz1.Rows[i].Cells[j].Value.ToString());
                    M1.InsertarMatriz(i, j, ObjRnEntero);
                    //Matriz M2
                    ObjRnEntero1.Num = Int32.Parse(this.dgwMatriz2.Rows[i].Cells[j].Value.ToString());
                    M2.InsertarMatriz(i, j, ObjRnEntero1);
                }
            }
            M1.f = Int32.Parse(this.txbFila.Text);
            M1.c = Int32.Parse(this.txbColumna.Text);

            M2.f = Int32.Parse(this.txbFila.Text);
            M2.c = Int32.Parse(this.txbColumna.Text);
        }
        private void LimpiarMatriz()
        {
            if (this.dgwMatriz1.Columns.Count > 0)
            {
              
               // this.dgwMatriz1.Rows.Clear();
               // this.dgwMatriz1.Columns.Clear();

               // this.dgwMatriz2.Rows.Clear();
              //  this.dgwMatriz2.Columns.Clear();

                this.dgwMatrizResultado.Rows.Clear();
                this.dgwMatrizResultado.Columns.Clear();
            }

        }
        private void MostrarMatriz(RnMatriz M)
        {
            this.LimpiarMatriz();
            this.Dimensionar(M.f, M.c);
            for (Int32 i = 0; i <= M.f - 1; i++)
            {
                for (Int32 j = 0; j <= M.c - 1; j++)
                {
                    this.dgwMatrizResultado.Rows[i].Cells[j].Value = M.LeerMatriz(i, j).Num;
                }
            }
        }
        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.dgwMatrizResultado.Visible = true;


            RnMatriz ObjM1 = new RnMatriz();
            RnMatriz ObjM2 = new RnMatriz();
            RnMatriz ObjM3 = new RnMatriz();
            this.CargarMatrizes(ref ObjM1,ref ObjM2);
            this.MostrarMatriz(ObjM3.SumarMatriz(ObjM1, ObjM2));

           }
    }
}
