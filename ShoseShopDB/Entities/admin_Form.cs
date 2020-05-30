namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_Form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin_Form()
        {
            admin_AccessGroupUserForm = new HashSet<admin_AccessGroupUserForm>();
            admin_AccessUserForm = new HashSet<admin_AccessUserForm>();
        }

        [Key]
        public int form_id { get; set; }

        public int? form_position { get; set; }

        public string form_name { get; set; }

        public string form_link { get; set; }

        public bool? form_active { get; set; }

        public int? module_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserForm> admin_AccessGroupUserForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessUserForm> admin_AccessUserForm { get; set; }

        public virtual admin_Module admin_Module { get; set; }
    }
}
