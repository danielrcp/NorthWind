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
    
    public partial class sm_Departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sm_Departamento()
        {
            this.sm_Ciudad = new HashSet<sm_Ciudad>();
        }
    
        public int idDepartamento { get; set; }
        public int idPais { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }
        public System.DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string updatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_Ciudad> sm_Ciudad { get; set; }
        public virtual sm_Pais sm_Pais { get; set; }
    }
}
