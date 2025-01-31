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
    public partial class frmVector : Form
    {
        public frmVector()
        {
            InitializeComponent();
        }
        private void Dimensionar(Int32 n)
        {
            if (this.dgwVector.Columns.Count > 0)
            {
                this.dgwVector.Columns.Clear();
                this.dgwVector.Rows.Clear();
            }
            for (int i = 0; i <= n- 1; i++)
            {
                this.dgwVector.Columns.Add(i.ToString(), i.ToString());
            }
            this.dgwVector.Rows.Add();
        }
        private void btnDimensionar_Click(object sender, EventArgs e)
        {
            this.Dimensionar (Int32.Parse (this.txbn.Text ));
        }
        private void CargarVector(ref RNVector ObjVector)
        {
            for (int i = 0;i<=int.Parse(this.txbn.Text) - 1; i++)
            {
                RNEntero rNEntero = new RNEntero();
                rNEntero.Num =Int32.Parse (this.dgwVector[i,0].Value.ToString ());
                ObjVector.InsertarVector(rNEntero);
            }
                
        }
        private void MostrarVector(RNVector ObjRNVector)
        {
            this.Dimensionar (ObjRNVector.n);
            for (int i = 0; i <= ObjRNVector.n - 1; i++)
            {
                this.dgwVector.Rows[0].Cells[i].Value = ObjRNVector.LeerVector(i).Num.ToString ()  ;   
            }
          
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            RNVector ObjVector= new RNVector();
            RNEntero rNEntero= new RNEntero();
            this.CargarVector(ref ObjVector);
            ObjVector.OrdenarVector();
            this.MostrarVector(ObjVector);
        }

        private void btnContarPrimos_Click(object sender, EventArgs e)
        {
            RNVector ObjVector = new RNVector();
            this.CargarVector(ref ObjVector);
            MessageBox.Show("existen :"+ ObjVector.ContarPrimos()+" numeros primos");
            
        }

        private void btnInvertirVector_Click(object sender, EventArgs e)
        {
            RNVector ObjVector = new RNVector();
            this.CargarVector(ref ObjVector);
            ObjVector.InvertirVector();
            this.MostrarVector(ObjVector);
        }
    }
}
