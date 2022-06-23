using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
