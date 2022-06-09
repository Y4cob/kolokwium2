using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Services
{
    public interface IAlbumServices
    {
        Task<AlbumServices>GetAlbumAsync(int id);

        Task<string>DelMuzykAsync(int id);
    }
}