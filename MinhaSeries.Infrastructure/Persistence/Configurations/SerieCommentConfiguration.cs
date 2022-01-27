using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaSeries.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Infrastructure.Persistence.Configurations
{
    public class SerieCommentConfiguration : IEntityTypeConfiguration<SerieComment>
    {
        public void Configure(EntityTypeBuilder<SerieComment> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .HasOne(p => p.Serie)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.IdSerie)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
