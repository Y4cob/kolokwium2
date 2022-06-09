using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Configurations
{
    public class MuzykConfig : IEntityTypeConfiguration<Muzyk>
    {
         public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.IdMusician).HasName("Musician_PK");
            builder.Property(e => e.IdMusician).UseIdentityColumn();

        
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
             builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
              builder.Property(e => e.NickName).HasMaxLength(100).IsRequired();
             



        
            var musicians = new List<Musician>();

            musicians.Add(new Musician
            {
                IdMusician =1,
                FirstName = "a",
                LastName = "b",
                NickName = "c",
              

            });

            builder.HasData(Album);

        
    }
    }
}