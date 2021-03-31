using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace YP.ModelsAndRepos.Discs
{
    public interface IDiscsRepository
    {
        public bool AddDisc(DiscModel disc);

        public IEnumerable<DiscModel> GetAllDiscs();

        public bool UpdateDisc(int serialNumber, int wholesalePrice, int retailPrice,
            int soldInCY, int howMuchLeft);

        public bool DeleteMusician(int serialNumber);
    }
}
