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
    
    public partial class sm_Rol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sm_Rol()
        {
            this.sm_RolOpcion = new HashSet<sm_RolOpcion>();
            this.sm_UsuarioRol = new HashSet<sm_UsuarioRol>();
        }
    
        public int idRol { get; set; }
        public string nombre { get; set; }
        public bool soloConsulta { get; set; }
        public string createdBy { get; set; }
        public System.DateTime createdDate { get; set; }
        public string updatedBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_RolOpcion> sm_RolOpcion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_UsuarioRol> sm_UsuarioRol { get; set; }
    }
}
