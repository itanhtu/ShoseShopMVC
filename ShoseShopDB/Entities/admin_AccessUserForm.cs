namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admin_AccessUserForm
    {
        [Key]
        public int uf_id { get; set; }

        public bool? uf_active { get; set; }

        public int? username_id { get; set; }

        public int? form_id { get; set; }

        public virtual admin_Form admin_Form { get; set; }

        public virtual admin_User admin_User { get; set; }
    }
}
