//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransaccionCuentaBancaria
    {
        public long id { get; set; }
        public Nullable<System.DateTime> FechaTranscaccion { get; set; }
        public double Monto { get; set; }
        public string GlosaTransaccion { get; set; }
        public string ResponsableTransaccion { get; set; }
        public string TipoTransaccion { get; set; }
        public long idcuentaBancaria { get; set; }
    
        public virtual CuentaBancaria CuentaBancaria { get; set; }
    }
}
