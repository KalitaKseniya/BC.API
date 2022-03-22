using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class PartModelProblemConfiguration : IEntityTypeConfiguration<PartModelProblem>
	{
		public void Configure(EntityTypeBuilder<PartModelProblem> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasIndex(x => new { x.ProblemId, x.PartModelId })
				.IsUnique();

			builder.HasOne(x => x.Part)
				.WithMany(pm => pm.PartModelProblems)
				.HasForeignKey(pm => pm.UserChosenPartId)
				.IsRequired(false);//Use can choose and can not choose

			builder.HasOne(x => x.PartModel)
				.WithMany(pm => pm.PartModelProblems)
				.HasForeignKey(pm => pm.PartModelId)
				.IsRequired(false);//master specifies after diagnostics
			
			builder.HasOne(x => x.Problem)
				.WithMany(pm => pm.PartModelProblems)
				.HasForeignKey(pm => pm.ProblemId);

			builder.Property(x => x.Amount)
				.HasDefaultValue(1);//ToDo K: add posititvity constraint?

			builder.Property(x => x.PricePerDetail)
				.HasPrecision(15, 2)
				.IsRequired(false);// required when part model is specified
		}
	}
}
