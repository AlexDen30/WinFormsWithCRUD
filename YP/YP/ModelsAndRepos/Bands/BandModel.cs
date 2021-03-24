using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.Bands
{
    public class BandModel
    {
        [Key]
        public int BandId { get; set; }

        public string BandName { get; set; }

        public int TypeId { get; set; }
    }

    public class BandType
    {
        [Key]
        public int TypeId { get; set; }

        public string DiscriptionOfType { get; set; }
    }
}
