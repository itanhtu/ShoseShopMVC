namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_GroupUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin_GroupUser()
        {
            admin_AccessGroupUserForm = new HashSet<admin_AccessGroupUserForm>();
            admin_AccessGroupUserForm1 = new HashSet<admin_AccessGroupUserForm>();
            admin_AccessGroupUserModule = new HashSet<admin_AccessGroupUserModule>();
            admin_AccessGroupUserModule1 = new HashSet<admin_AccessGroupUserModule>();
            admin_User = new HashSet<admin_User>();
        }

        [Key]
        public int groupuser_id { get; set; }

        public string groupuser_name { get; set; }

        public bool? groupuser_active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserForm> admin_AccessGroupUserForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserForm> admin_AccessGroupUserForm1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserModule> admin_AccessGroupUserModule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessGroupUserModule> admin_AccessGroupUserModule1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_User> admin_User { get; set; }
    }
}
