using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.Bands
{
    public interface IBandsRepository
    {
        public bool AddBand(BandModel band);

        public IEnumerable<BandModel> GetAllBands();

        public bool UpdateBandName(string oldName, string newName);

        public bool DeleteBand(string bandName);
    }
}
