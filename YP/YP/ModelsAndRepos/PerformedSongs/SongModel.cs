using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.PerformedSongs
{

    public class PerformedSongModel
    {
        [Key]
        public int PerformanceId { get; set; }

        public int SongId { get; set; }

        public string SongName { get; set; }

        public string CircumstancesOfPerfomance { get; set; }

        public int AuthorId { get; set; }
    }

}
