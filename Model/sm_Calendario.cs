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
    
    public partial class sm_Calendario
    {
        public int idCalendario { get; set; }
        public int idPaciente { get; set; }
        public Nullable<System.DateTime> fechaDesde { get; set; }
        public Nullable<System.TimeSpan> horaDesde { get; set; }
        public Nullable<System.DateTime> fechaHasta { get; set; }
        public Nullable<System.TimeSpan> horaHasta { get; set; }
        public string descripcion { get; set; }
        public int idOrigen { get; set; }
        public int idEstado { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string updatedBy { get; set; }
    }
}
