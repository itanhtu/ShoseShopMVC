namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbOrderDetail")]
    public partial class tbOrderDetail
    {
        public int? orderdetail_amount { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int product_id { get; set; }

        public virtual tbOrder tbOrder { get; set; }

        public virtual tbOrder tbOrder1 { get; set; }

        public virtual tbProduct tbProduct { get; set; }

        public virtual tbProduct tbProduct1 { get; set; }
    }
}
