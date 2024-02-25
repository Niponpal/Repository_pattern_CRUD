using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Models;

namespace SMS.ModelConfigration;

public class SchoolCongigraion : IEntityTypeConfiguration<School>
{
	public void Configure(EntityTypeBuilder<School> builder)
	{
		builder.ToTable(nameof(School));
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
		builder.Property(x => x.Age).HasMaxLength(50).IsRequired();
		builder.Property(x => x.Address).HasMaxLength(50).IsRequired();
		builder.HasData(new School { 
			Id=1,
			Name="Nipon",
			Age="32",
			Address="Nawabgonj"
		});
	}
}
