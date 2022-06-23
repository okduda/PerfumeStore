using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class PerfumeRepository : BaseRepository<Perfume>, IPerfumeRepository
    {
        public PerfumeRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
