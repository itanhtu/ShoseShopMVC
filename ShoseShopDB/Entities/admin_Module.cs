namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin_Module()
        {
            admin_AccessGroupUserModule = new HashSet<admin_AccessGroupUserModule>();
            admin_AccessGroupUserModule1 = new HashSet<admin_AccessGroupUserModule>();
            admin_Form = new HashSet<admin_Form>();
            admin_Form1 = new HashSet<admin_Form>();
        }

        [Key]
        public int module_id { get; set; }

        public int? module_position { get; set; }

        public string module_name { get; set; }

        public string module_icon { get; set; }

        public bool? module_active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserModule> admin_AccessGroupUserModule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserModule> admin_AccessGroupUserModule1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_Form> admin_Form { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_Form> admin_Form1 { get; set; }
    }
}
