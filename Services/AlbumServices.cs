using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public class AlbumServices : IAlbumServices
    {
        private readonly Context context;

        
    }
    public AlbumServices(Context context){
        this.context = context;
    }
     public async Task<string> DelMuzykAsync(int id){
    var IdMusician = await context.Muzyk.FindAsync(id);
    if(Muzyk == null){
     return "nie ma takiego Muzyka";
    }else{
    context.Remove(IdMusician);

    await context.SaveChangesAsync();

    return "Usunieto";
         }
    }


public async Task<Album> GetAlbumAsync(int id){
         var alb = await context.Album.FindAsync(id);

         if(alb == null){
             return "Error";
         }else{
             Album Album = await context.Album.Where(e=>
             e.IdAlbum == id).Select(e=> new Album{


             AlbumName = e.AlbumName,
             PublishDate = e.PublishDate,
             
             Track = e.Track.Select(e=> new Track{
                 Name = e.IdTrackNav.Name,
                 TrackName = e.TrackName,
                 Duration = e.Duration
             })
             }).FirstAsync();
  
            

             return Album;
         }
     }
}