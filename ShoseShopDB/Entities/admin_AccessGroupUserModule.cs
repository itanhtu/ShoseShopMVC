namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_AccessGroupUserModule
    {
        [Key]
        public int gum_id { get; set; }

        public bool? gum_active { get; set; }

        public int? groupuser_id { get; set; }

        public int? module_id { get; set; }

        public virtual admin_GroupUser admin_GroupUser { get; set; }

        public virtual admin_Module admin_Module { get; set; }

        public virtual admin_GroupUser admin_GroupUser1 { get; set; }

        public virtual admin_Module admin_Module1 { get; set; }
    }
}
