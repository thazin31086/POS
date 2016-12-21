namespace Jasmine.POS.Data
{
    using System.Configuration;
    using System.Data.Entity;
    public partial class JasminePOSDBContext : DbContext
    {
        public static string ConnectionStringName
        {
            get
            {
              return  ConfigurationManager.ConnectionStrings["JasminePOSDB"].ToString();
            }
        }
        public JasminePOSDBContext()
            : base(nameOrConnectionString : JasminePOSDBContext.ConnectionStringName)
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
