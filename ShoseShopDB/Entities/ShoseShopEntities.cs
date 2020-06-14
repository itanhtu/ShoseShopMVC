namespace ShoseShopDB.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShoseShopEntities : DbContext
    {
        public ShoseShopEntities()
            : base("name=ShoseShopEntities")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<admin_AccessGroupUserForm> admin_AccessGroupUserForm { get; set; }
        public virtual DbSet<admin_AccessGroupUserModule> admin_AccessGroupUserModule { get; set; }
        public virtual DbSet<admin_AccessUserForm> admin_AccessUserForm { get; set; }
        public virtual DbSet<admin_Form> admin_Form { get; set; }
        public virtual DbSet<admin_GroupUser> admin_GroupUser { get; set; }
        public virtual DbSet<admin_Module> admin_Module { get; set; }
        public virtual DbSet<admin_User> admin_User { get; set; }
        public virtual DbSet<tbContact> tbContacts { get; set; }
        public virtual DbSet<tbContactCustomer> tbContactCustomers { get; set; }
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
                .HasForeignKey(e => e.form_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Form>()
                .HasMany(e => e.admin_AccessGroupUserForm1)
                .WithOptional(e => e.admin_Form1)
                .HasForeignKey(e => e.form_id);

            modelBuilder.Entity<admin_Form>()
                .HasMany(e => e.admin_AccessUserForm)
                .WithOptional(e => e.admin_Form)
                .HasForeignKey(e => e.form_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Form>()
                .HasMany(e => e.admin_AccessUserForm1)
                .WithOptional(e => e.admin_Form1)
                .HasForeignKey(e => e.form_id);

            modelBuilder.Entity<admin_GroupUser>()
                .HasMany(e => e.admin_AccessGroupUserForm)
                .WithOptional(e => e.admin_GroupUser)
                .HasForeignKey(e => e.groupuser_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_GroupUser>()
                .HasMany(e => e.admin_AccessGroupUserForm1)
                .WithOptional(e => e.admin_GroupUser1)
                .HasForeignKey(e => e.groupuser_id);

            modelBuilder.Entity<admin_GroupUser>()
                .HasMany(e => e.admin_AccessGroupUserModule)
                .WithOptional(e => e.admin_GroupUser)
                .HasForeignKey(e => e.groupuser_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_GroupUser>()
                .HasMany(e => e.admin_AccessGroupUserModule1)
                .WithOptional(e => e.admin_GroupUser1)
                .HasForeignKey(e => e.groupuser_id);

            modelBuilder.Entity<admin_Module>()
                .HasMany(e => e.admin_AccessGroupUserModule)
                .WithOptional(e => e.admin_Module)
                .HasForeignKey(e => e.module_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Module>()
                .HasMany(e => e.admin_AccessGroupUserModule1)
                .WithOptional(e => e.admin_Module1)
                .HasForeignKey(e => e.module_id);

            modelBuilder.Entity<admin_Module>()
                .HasMany(e => e.admin_Form)
                .WithOptional(e => e.admin_Module)
                .HasForeignKey(e => e.module_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_Module>()
                .HasMany(e => e.admin_Form1)
                .WithOptional(e => e.admin_Module1)
                .HasForeignKey(e => e.module_id);

            modelBuilder.Entity<admin_User>()
                .HasMany(e => e.admin_AccessUserForm)
                .WithOptional(e => e.admin_User)
                .HasForeignKey(e => e.username_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<admin_User>()
                .HasMany(e => e.admin_AccessUserForm1)
                .WithOptional(e => e.admin_User1)
                .HasForeignKey(e => e.username_id);

            modelBuilder.Entity<tbOrder>()
                .HasMany(e => e.tbOrderDetails)
                .WithRequired(e => e.tbOrder)
                .HasForeignKey(e => e.order_id);

            modelBuilder.Entity<tbOrder>()
                .HasMany(e => e.tbOrderDetails1)
                .WithRequired(e => e.tbOrder1)
                .HasForeignKey(e => e.order_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbProduct>()
                .HasMany(e => e.tbOrderDetails)
                .WithRequired(e => e.tbProduct)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<tbProduct>()
                .HasMany(e => e.tbOrderDetails1)
                .WithRequired(e => e.tbProduct1)
                .HasForeignKey(e => e.product_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbProduct>()
                .HasMany(e => e.tbSumCartDetails)
                .WithRequired(e => e.tbProduct)
                .HasForeignKey(e => e.product_id);

            modelBuilder.Entity<tbProduct>()
                .HasMany(e => e.tbSumCartDetails1)
                .WithRequired(e => e.tbProduct1)
                .HasForeignKey(e => e.product_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbSumCart>()
                .HasMany(e => e.tbSumCartDetails)
                .WithRequired(e => e.tbSumCart)
                .HasForeignKey(e => e.sumcart_id);

            modelBuilder.Entity<tbSumCart>()
                .HasMany(e => e.tbSumCartDetails1)
                .WithRequired(e => e.tbSumCart1)
                .HasForeignKey(e => e.sumcart_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbSumCarts)
                .WithRequired(e => e.tbUser)
                .HasForeignKey(e => e.user_id);

            modelBuilder.Entity<tbUser>()
                .HasMany(e => e.tbSumCarts1)
                .WithRequired(e => e.tbUser1)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
