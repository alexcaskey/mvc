using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication2.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(50);

            this.Property(t => t.address)
                .HasMaxLength(50);

            this.Property(t => t.city)
                .HasMaxLength(50);

            this.Property(t => t.state)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip)
                .HasMaxLength(50);

            this.Property(t => t.phone)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("People");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.phone).HasColumnName("phone");
        }
    }
}
