//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class sm_FiltroNotificaciones
    {
        public int id { get; set; }
        public int idTipoIdentificacion { get; set; }
        public string numeroIdentificacion { get; set; }
        public string tipoMonitoreo { get; set; }
        public int periodicidad { get; set; }
        public int activoMonitoreo { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
        public Nullable<int> cantidadTomas { get; set; }
        public string horaInicio { get; set; }
        public Nullable<int> tipoEvento { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> idGuiaPaciente { get; set; }
        public Nullable<int> idEstado { get; set; }
    }
}