using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Configurations
{
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    {
         public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.IdAlbum).HasName("Album_PK");
            builder.Property(e => e.IdAlbum).UseIdentityColumn();

        
            builder.Property(e => e.AlbumName).HasMaxLength(100).IsRequired();
             builder.Property(e => e.PublishDate).IsRequired();



            // adding data
            var albums = new List<Album>();

            albums.Add(new Album
            {
                IdAlbum =1,
                AlbumName = "elo",
                PublishDate = DateTime.Now

            });

            builder.HasData(Album);

        
    }
}
}