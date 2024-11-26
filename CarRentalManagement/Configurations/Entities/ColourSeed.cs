using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        void IEntityTypeConfiguration<Colour>.Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                 new Colour
                 {
                     Id = 1,
                     Name = "Black",
                     DateCreated = DateTime.Now,
                     DataUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Colour
                 {
                     Id = 2,
                     Name = "Blue",
                     DateCreated = DateTime.Now,
                     DataUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            );
        }
    }
}
