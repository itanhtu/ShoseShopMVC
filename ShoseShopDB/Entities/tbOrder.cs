namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbOrder")]
    public partial class tbOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbOrder()
        {
            tbOrderDetails = new HashSet<tbOrderDetail>();
            tbOrderDetails1 = new HashSet<tbOrderDetail>();
        }

        [Key]
        public int order_id { get; set; }

        public DateTime? order_date { get; set; }

        public bool? order_status { get; set; }

        public int? order_statusProduct { get; set; }

        public DateTime? order_sucssesdate { get; set; }

        public string order_note { get; set; }

        public int? user_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrderDetail> tbOrderDetails { get; set; }

        public virtual tbUser tbUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrderDetail> tbOrderDetails1 { get; set; }
    }
}
