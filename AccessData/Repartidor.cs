//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repartidor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repartidor()
        {
            this.EntregaPedido = new HashSet<EntregaPedido>();
        }
    
        public int id_Repartidor { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Licencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregaPedido> EntregaPedido { get; set; }
    }
}