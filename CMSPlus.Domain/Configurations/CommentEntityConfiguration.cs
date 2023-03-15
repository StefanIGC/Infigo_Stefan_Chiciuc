using CMSPlus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMSPlus.Domain.Configurations;

public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
{
    public void Configure(EntityTypeBuilder<CommentEntity> builder)
    {
        builder.ToTable("Comments");
        builder.HasOne(c => c.Topic)
            .WithMany(c => c.Comments)
            .HasForeignKey(c => c.TopicId);
        builder.Property(x => x.FullName).IsRequired();
        builder.Property(x => x.Comment).IsRequired();
    }
}