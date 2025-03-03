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
    
    public partial class CuentaBancaria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaBancaria()
        {
            this.TransaccionCuentaBancaria = new HashSet<TransaccionCuentaBancaria>();
        }
    
        public long id { get; set; }
        public string NroCuenta { get; set; }
        public string Moneda { get; set; }
        public Nullable<System.DateTime> FechaApertura { get; set; }
        public string NombrecompletoTitular1 { get; set; }
        public string NombreCompletoTitular2 { get; set; }
        public long idEmpleado { get; set; }
        public long idEntidadFinanciera { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual EntidadFinanciera EntidadFinanciera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionCuentaBancaria> TransaccionCuentaBancaria { get; set; }
    }
}
