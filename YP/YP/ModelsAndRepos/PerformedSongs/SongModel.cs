﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.PerformedSongs
{
    public class SongModel
    {
        [Key]
        public int SongId { get; set; }

        public string SongName { get; set; }

        public string CircumstancesOfWriting { get; set; }
    }

    public class PerformedSongModel
    {
        [Key]
        public int PerformanceId { get; set; }

        public int SongId { get; set; }

        public string SongName { get; set; }

        public string CircumstancesOfPerfomance { get; set; }
    }

    public class DiscHasSong
    {
        public int SongPerfomanceId { get; set; }
        public int DiscSerialNumber { get; set; }
        public int SongNumber { get; set; }

    }

    public class AuthorOfASong
    {
        public int AuthorId { get; set; }

        public int SongId { get; set; }
    }

}
