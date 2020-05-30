namespace ShoseShopDB.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShoseShopEntities : DbContext
    {
        public ShoseShopEntities()
            : base("name=ShoseShopConnectionString")
        {
        }

        public virtual DbSet<admin_AccessGroupUserForm> admin_AccessGroupUserForm { get; set; }
        public virtual DbSet<admin_AccessGroupUserModule> admin_AccessGroupUserModule { get; set; }
        public virtual DbSet<admin_AccessUserForm> admin_AccessUserForm { get; set; }
        public virtual DbSet<admin_Form> admin_Form { get; set; }
        public virtual DbSet<admin_GroupUser> admin_GroupUser { get; set; }
        public virtual DbSet<admin_Module> admin_Module { get; set; }
        public virtual DbSet<admin_User> admin_User { get; set; }
        public virtual DbSet<tbContact> tbContacts { get; set; }
        public virtual DbSet<tbCustomer> tbCustomers { get; set; }
        public virtual DbSet<tbCustomerFeedback> tbCustomerFeedbacks { get; set; }
        public virtual DbSet<tbIntroduce> tbIntroduces { get; set; }
        public virtual DbSet<tbNew> tbNews { get; set; }
        public virtual DbSet<tbOrder> tbOrders { get; set; }
        public virtual DbSet<tbOrderDetail> tbOrderDetails { get; set; }
        public virtual DbSet<tbProduct> tbProducts { get; set; }
        public virtual DbSet<tbProductCate> tbProductCates { get; set; }
        public virtual DbSet<tbSlide> tbSlides { get; set; }
        public virtual DbSet<tbSumCart> tbSumCarts { get; set; }
        public virtual DbSet<tbSumCartDetail> tbSumCartDetails { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin_Form>()
                .HasMany(e => e.admin_AccessGroupUserForm)
                .WithOptional(e => e.admin_Form)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Form>()
                .HasMany(e => e.admin_AccessUserForm)
                .WithOptional(e => e.admin_Form)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_GroupUser>()
                .HasMany(e => e.admin_AccessGroupUserForm)
                .WithOptional(e => e.admin_GroupUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_GroupUser>()
                .HasMany(e => e.admin_AccessGroupUserModule)
                .WithOptional(e => e.admin_GroupUser)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Module>()
                .HasMany(e => e.admin_AccessGroupUserModule)
                .WithOptional(e => e.admin_Module)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Module>()
                .HasMany(e => e.admin_Form)
                .WithOptional(e => e.admin_Module)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_User>()
                .HasMany(e => e.admin_AccessUserForm)
                .WithOptional(e => e.admin_User)
                .WillCascadeOnDelete();

            modelBuilder.Entity<tbOrder>()
                .HasMany(e => e.tbOrderDetails)
                .WithRequired(e => e.tbOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbProduct>()
                .HasMany(e => e.tbOrderDetails)
                .WithRequired(e => e.tbProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbProduct>()
                .HasMany(e => e.tbSumCartDetails)
                .WithRequired(e => e.tbProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbSumCart>()
                .HasMany(e => e.tbSumCartDetails)
                .WithRequired(e => e.tbSumCart)
                .WillCascadeOnDelete(false);
        }
    }
}
