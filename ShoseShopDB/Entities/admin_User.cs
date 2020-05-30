namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public admin_User()
        {
            admin_AccessUserForm = new HashSet<admin_AccessUserForm>();
        }

        [Key]
        public int username_id { get; set; }

        public string username_username { get; set; }

        public string username_password { get; set; }

        public string username_fullname { get; set; }

        public bool? username_gender { get; set; }

        public string username_phone { get; set; }

        public string username_email { get; set; }

        public int? groupuser_id { get; set; }

        public bool? hide { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin_AccessUserForm> admin_AccessUserForm { get; set; }

        public virtual admin_GroupUser admin_GroupUser { get; set; }
    }
}
