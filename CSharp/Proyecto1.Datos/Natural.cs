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
    
    public partial class Natural
    {
        public long id { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Genero { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string DocumentoIdentidad { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
