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
    
    public partial class Clientes
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Tipos_de_ClientesId { get; set; }
    
        public virtual Tipos_de_Clientes Tipos_de_Clientes { get; set; }
    }
}
