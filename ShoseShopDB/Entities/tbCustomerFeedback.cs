namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCustomerFeedback")]
    public partial class tbCustomerFeedback
    {
        [Key]
        public int customer_id { get; set; }

        public string customer_name { get; set; }

        public string customer_country { get; set; }

        public string customer_content { get; set; }

        public string customer_image { get; set; }

        public DateTime? customer_date { get; set; }

        public bool? customer_active { get; set; }
    }
}
