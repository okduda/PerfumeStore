using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
