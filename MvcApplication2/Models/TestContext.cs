using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MvcApplication2.Models.Mapping;

namespace MvcApplication2.Models
{
    public partial class TestContext : DbContext
    {
        static TestContext()
        {
            Database.SetInitializer<TestContext>(null);
        }

        public TestContext()
            : base("Name=TestContext")
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonMap());
        }
    }
}
