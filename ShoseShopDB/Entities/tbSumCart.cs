namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbSumCart")]
    public partial class tbSumCart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbSumCart()
        {
            tbSumCartDetails = new HashSet<tbSumCartDetail>();
            tbSumCartDetails1 = new HashSet<tbSumCartDetail>();
        }

        [Key]
        public int sumcart_id { get; set; }

        public int user_id { get; set; }

        public virtual tbUser tbUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSumCartDetail> tbSumCartDetails { get; set; }

        public virtual tbUser tbUser1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSumCartDetail> tbSumCartDetails1 { get; set; }
    }
}
