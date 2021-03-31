using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.PerformedSongs
{
    public interface ISongsRepository
    {
        public bool AddPSong(string songName, string circumstOfPerf,
            int authorId);

        public IEnumerable<PerformedSongModel> GetAllPSongs();

        public bool UpdatePSong(int perfId, string newCirumstOfPerf);

        public bool DeletePSong(int perfId);
    }
}
