namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbProductCate")]
    public partial class tbProductCate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProductCate()
        {
            tbProducts = new HashSet<tbProduct>();
        }

        [Key]
        public int productcate_id { get; set; }

        public int? productcate_position { get; set; }

        public string productcate_title { get; set; }

        public bool? productcate_show { get; set; }

        public int? productgroup_id { get; set; }

        public string title_web { get; set; }

        public int? productcate_parent { get; set; }

        public string productcate_content { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProduct> tbProducts { get; set; }
    }
}
