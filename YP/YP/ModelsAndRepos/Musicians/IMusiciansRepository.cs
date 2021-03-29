using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YP.ModelsAndRepos.Musicians
{
    public interface IMusiciansRepository
    {
        public bool AddMusician(string firstName, string surname, 
            string bandName, string roleDesc);

        public IEnumerable<MusicianModel> GetAllMusicians();

        public bool UpdateMusician(string firstName, string surname,
            string bandName, string roleDesc);

        public bool DeleteMusician(string firstName, string surname);
    }
}
