namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbIntroduce")]
    public partial class tbIntroduce
    {
        [Key]
        public int introduct_id { get; set; }

        public string introduce_title { get; set; }

        public string introduce_title1 { get; set; }

        public string introduce_summary { get; set; }

        public string introduce_content { get; set; }

        public string introduce_image { get; set; }

        public DateTime? introduce_dateup { get; set; }

        public bool? introduce_active { get; set; }
    }
}
