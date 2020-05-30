namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_AccessGroupUserForm
    {
        [Key]
        public int guf_id { get; set; }

        public bool? guf_active { get; set; }

        public int? groupuser_id { get; set; }

        public int? form_id { get; set; }

        public virtual admin_Form admin_Form { get; set; }

        public virtual admin_GroupUser admin_GroupUser { get; set; }
    }
}
