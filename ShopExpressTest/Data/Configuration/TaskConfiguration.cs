using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopExpressTest.Entities;

namespace ShopExpressTest.Data.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<UserTask>
    {
        public void Configure(EntityTypeBuilder<UserTask> builder)
        {
            builder.HasKey(t => t.Id); // Id є первинним ключем.

            builder.Property(t => t.Title)
                .IsRequired() // Назва завдання є обов'язковим полем.
                .HasMaxLength(100); // Максимальна довжина назви завдання.

            builder.Property(t => t.IsCompleted)
                .IsRequired(); // IsCompleted є обов'язковим.
        }
    }
}
