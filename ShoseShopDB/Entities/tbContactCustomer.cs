namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbContactCustomer")]
    public partial class tbContactCustomer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int concus_id { get; set; }

        public int? concus_name { get; set; }

        public int? concus_email { get; set; }

        public int? concus_phone { get; set; }

        public int? concus_content { get; set; }

        public int? concus_date { get; set; }
    }
}
