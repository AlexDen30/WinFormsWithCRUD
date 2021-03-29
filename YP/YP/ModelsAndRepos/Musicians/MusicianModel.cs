using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.Musicians
{
    public class MusicianModel
    {
        [Key]
        public int MusicianId { get; set; }

        public int RoleId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string DiscriptionOfRole { get; set; }

        public string BandName { get; set; }
    }

    //public class MusicRole
    //{
    //    [Key]
    //    public int RoleId { get; set; }

    //    public string DiscriptionOfRole { get; set; }
    //}

    //public class MusicianHasBand
    //{
    //    public int MusicianId { get; set; }

    //    public int BandId { get; set; }
    //}

   
}
