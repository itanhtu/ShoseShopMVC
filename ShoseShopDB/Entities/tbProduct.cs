namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbProduct")]
    public partial class tbProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProduct()
        {
            tbOrderDetails = new HashSet<tbOrderDetail>();
            tbSumCartDetails = new HashSet<tbSumCartDetail>();
        }

        [Key]
        public int product_id { get; set; }

        public int? product_position { get; set; }

        public string product_title { get; set; }

        public int? product_hot { get; set; }

        public string product_image { get; set; }

        public string product_summary { get; set; }

        public string product_content { get; set; }

        public int? product_quantum { get; set; }

        public bool? product_show { get; set; }

        public bool? product_new { get; set; }

        public int? productcate_id { get; set; }

        public string title_web { get; set; }

        public int? product_cart { get; set; }

        public int? product_price { get; set; }

        public bool? product_active { get; set; }

        public DateTime? product_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrderDetail> tbOrderDetails { get; set; }

        public virtual tbProductCate tbProductCate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSumCartDetail> tbSumCartDetails { get; set; }
    }
}
