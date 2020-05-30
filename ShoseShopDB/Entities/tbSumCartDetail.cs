namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbSumCartDetail")]
    public partial class tbSumCartDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sumcart_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int product_id { get; set; }

        public int? sumcartdetail_amount { get; set; }

        public virtual tbProduct tbProduct { get; set; }

        public virtual tbSumCart tbSumCart { get; set; }
    }
}
