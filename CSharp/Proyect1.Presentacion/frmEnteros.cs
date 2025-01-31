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
    public partial class frmEnteros : Form
    {
        public frmEnteros()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            RNEntero ObjRnEntero=new RNEntero ();
            ObjRnEntero.Num = Int32.Parse(txbNumero.Text);
            this.txbNumero.Text= ObjRnEntero.Invertir().ToString();

        }

        private void btnCapicua_Click(object sender, EventArgs e)
        {
            RNEntero ObjRnEntero = new RNEntero();
            ObjRnEntero.Num = Int32.Parse(txbNumero.Text);
            if (ObjRnEntero.Capicua())
            {
                MessageBox.Show("Es Capicual");
            }
            else
            {
                MessageBox.Show("No es capicual");
            }
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            RNEntero ObjRnEntero = new RNEntero();
            ObjRnEntero.Num = Int32.Parse(txbNumero.Text);
            if (ObjRnEntero.Primo())
            {
                MessageBox.Show("Es primo");
            }
            else
            {
                MessageBox.Show("No es primo");
            }

        }
    }
}
