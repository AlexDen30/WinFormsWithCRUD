using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.Discs
{
    public class DiscModel
    {
        public string Title { get; set; }

        public int BandId { get; set; }

        [Key]
        public int SerialNumber { get; set; }

        public float WholesalePrice { get; set; }

        public float RetailPrice { get; set; }

        public string DateOfRelease { get; set; }

        public int SaledInLastYear { get; set; }

        public int SaledInCurrentYear { get; set; }

        public int HowMuchLeft { get; set; }

        public string WholesaleCompany { get; set; }

        public string ListOfSongs { get; set; }
    }

    public class DiscHasSong
    {
        public int SongPerfomanceId { get; set; }
        public int DiscSerialNumber { get; set; }
        public int SongNumber { get; set; }

    }
}
