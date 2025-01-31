using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Preyecto1.RN;
using Proyecto1.Datos;

using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Attributes;
namespace Proyecto1.presentacionweb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.CargarComboRubro();
                this.CargarComboCiudad();
                Summary Sumary = BenchmarkRunner.Run <RNCliente>();
                Console.WriteLine(Sumary);


                //BenchmarkRunner.Run<RNCliente>();
            }
        }

        private void CargarComboRubro()
        {
            RNRubro objRnRubro = new RNRubro();
            cbRubro.DataSource = objRnRubro.TraerRubro(0);
            cbRubro.DataTextField = "NombreRubro";
            cbRubro.DataValueField = "id";
            cbRubro.DataBind();
        }
        private void CargarComboCiudad()
        {
            RNCiudad objrnCiudad = new RNCiudad();
            cbCiudad.DataSource = objrnCiudad.TraerCiudad(0);
            cbCiudad.DataTextField = "NombreCiudad";
            cbCiudad.DataValueField = "id";
            cbCiudad.DataBind();
        }
        public void GUardarClienteNatural()
        {
            Cliente ObjCliente = new Cliente();
            RNCliente objRnCliente = new RNCliente();
            ObjCliente.id = objRnCliente.GenerarId();
            ObjCliente.Direccion = this.txbDireccion.Text;
            ObjCliente.Telefono = this.txbTelefono.Text;
            ObjCliente.Telefono2 = this.txbTelefono.Text;
            ObjCliente.Nit = long.Parse(this.txbNit.Text);
            ObjCliente.idrubro = long.Parse(this.cbRubro.SelectedValue.ToString());
            ObjCliente.idCiuddad = long.Parse(this.cbCiudad.SelectedValue.ToString());

            Natural ObjNatural = new Natural();
            ObjNatural.id = ObjCliente.id;
            ObjNatural.NombreCliente = this.txbNombre.Text;
            ObjNatural.ApellidoPaterno = this.txbApellidoPaterno.Text;
            ObjNatural.ApellidoMaterno = this.txbApellidomaterno.Text;
            if (rbFemenino.Checked == true)
                ObjNatural.Genero = "Femenino";
            else
                ObjNatural.Genero = "Masculino";
            ObjNatural.FechaNacimiento = DateTime.Parse(txbFechaNacimiento.Text);
            ObjNatural.DocumentoIdentidad = this.txbDocumentoIdentidad.Text;
            if (objRnCliente.InsertarClienteNatural(ObjCliente, ObjNatural))
            {
                Label14.Text = "Cliente Insertado";
            }
            else
            {
                Label14.Text = "Error en el registro!!!";
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           
            this.GUardarClienteNatural();
         
        }

    }    
        
               
 
}