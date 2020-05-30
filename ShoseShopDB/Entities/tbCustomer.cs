namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCustomer")]
    public partial class tbCustomer
    {
        [Key]
        public int cus_id { get; set; }

        public string cus_name { get; set; }

        public string cus_email { get; set; }

        public string cus_phone { get; set; }

        public string cus_content { get; set; }

        public DateTime? cus_date { get; set; }

        public bool? cus_active { get; set; }
    }
}
