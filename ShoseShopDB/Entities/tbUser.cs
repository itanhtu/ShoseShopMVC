namespace ShoseShopDB.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbUser")]
    public partial class tbUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUser()
        {
            tbOrders = new HashSet<tbOrder>();
            tbSumCarts = new HashSet<tbSumCart>();
            tbSumCarts1 = new HashSet<tbSumCart>();
        }

        [Key]
        public int user_id { get; set; }

        public string user_name { get; set; }

        public string user_login { get; set; }

        public string user_password { get; set; }

        public string user_phone { get; set; }

        public string user_mail { get; set; }

        public string user_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrder> tbOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSumCart> tbSumCarts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSumCart> tbSumCarts1 { get; set; }
    }
}
