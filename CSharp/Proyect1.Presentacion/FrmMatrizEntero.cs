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
    public partial class FrmMatrizEntero : Form
    {
        public FrmMatrizEntero()
        {
            InitializeComponent();
        }
        private  void Dimensionar(Int32 Fila, Int32 columnas){
            this.dgwMatriz.Rows.Clear();
            this.dgwMatriz.Columns.Clear();
            for(Int32 i=0;i<= columnas - 1; i++)
            {
                this.dgwMatriz.Columns.Add(i.ToString(), i.ToString());
            }

            for (Int32 i = 0; i <= Fila - 1; i++)
            {
                this.dgwMatriz.Rows.Add();
            }
        }
        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            this.Dimensionar(Int32.Parse(this.txbFila.Text), Int32.Parse(this.txbColumna.Text));
        }
        private void CargarMatriz (ref RnMatriz M)
        {

            for (Int32 i = 0; i <= Int32.Parse(this.txbFila.Text)  - 1; i++)
            {
                for (Int32 j = 0; j <= Int32.Parse(this.txbColumna.Text) - 1; j++)
                {
                    RNEntero ObjRnEntero = new RNEntero();
                    ObjRnEntero.Num = Int32.Parse (this.dgwMatriz.Rows[i].Cells[j].Value.ToString ());
                    M.InsertarMatriz(i,j,ObjRnEntero);
                }
            }
            M.f= Int32.Parse(this.txbFila.Text);
            M.c = Int32.Parse(this.txbColumna.Text);
        }

        private void MostrarMatriz(RnMatriz M)
        {
            this.LimpiarMatriz();
            this.Dimensionar(M.f, M.c);
            for (Int32 i = 0; i <= M.f - 1; i++)
            {
                for (Int32 j = 0; j <= M.c - 1; j++)
                {
                    this.dgwMatriz.Rows[i].Cells[j].Value = M.LeerMatriz(i, j).Num;
                }
            }
        }
        private void LimpiarMatriz()
        {
            if (this.dgwMatriz.Columns.Count > 0){
                this.dgwMatriz.Rows.Clear();
                this.dgwMatriz.Columns.Clear();
            }
         
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            RnMatriz ObjRNMAtriz = new RnMatriz();
            this.CargarMatriz(ref ObjRNMAtriz);
            ObjRNMAtriz.OrdenarMatriz();
            this.MostrarMatriz(ObjRNMAtriz);
        }

        private void btnContarPrimos_Click(object sender, EventArgs e)
        {
            RnMatriz ObjRNMAtriz = new RnMatriz();
            this.CargarMatriz(ref ObjRNMAtriz);
            MessageBox.Show("Exinten:" + ObjRNMAtriz.ContarPrimos().ToString() + " numeros primos");
        }
    }
}
