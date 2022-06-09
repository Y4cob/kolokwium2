using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Configurations
{
    public class TrackController :IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(e => e.IdTrack).HasName("Track_PK");
            builder.Property(e => e.IdTrack).UseIdentityColumn();

        
            builder.Property(e => e.TrackName).HasMaxLength(100).IsRequired();
             builder.Property(e => e.Duration).HasMaxLength(100).IsRequired();
              builder.Property(e => e.IdMusicAlbum).UseIdentityColumn();
             



        
            var track = new List<Track>();

            track.Add(new Track
            {
                IdTrack =1,
                TrackName = "aaa",
                Duration = 2.0,
                IdMusicAlbum = 1

            });

            builder.HasData(track);

        
    }
    }
}
    
