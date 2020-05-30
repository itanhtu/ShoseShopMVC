namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbSlide")]
    public partial class tbSlide
    {
        [Key]
        public int slide_id { get; set; }

        public string slide_image { get; set; }

        public string slide_title { get; set; }

        public string slide_link { get; set; }

        public bool? hidden { get; set; }

        public bool? slide_active { get; set; }

        public string slide_summary { get; set; }

        public DateTime? slide_date { get; set; }
    }
}
