namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbNew
    {
        [Key]
        public int news_id { get; set; }

        public string news_title { get; set; }

        public string news_image { get; set; }

        public string news_summary { get; set; }

        public string news_content { get; set; }

        public DateTime? news_createdate { get; set; }

        public bool? news_show { get; set; }

        public int? newscate_id { get; set; }

        public string title_web { get; set; }

        public bool? hidden { get; set; }

        public DateTime? news_datetime { get; set; }
    }
}
