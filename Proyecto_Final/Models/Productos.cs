//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public System.DateTime Fecha_Creacion { get; set; }
        public System.DateTime Fecha_Vencimiento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UdM { get; set; }
        public string Costo { get; set; }
        public string Existencia { get; set; }
        public string Estado { get; set; }
    }
}
