namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbContact")]
    public partial class tbContact
    {
        [Key]
        public int contact_id { get; set; }

        public string contact_address { get; set; }

        public string contact_email { get; set; }

        public string contact_link { get; set; }

        public string contact_hotline { get; set; }

        public string contact_name { get; set; }

        public string contact_facebook { get; set; }

        public string contact_twitter { get; set; }

        public string contact_instagram { get; set; }

        public string contact_title { get; set; }
    }
}
