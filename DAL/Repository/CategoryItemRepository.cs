using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class CategoryItemRepository : BaseRepository<CategoryItem>, ICategoryItemRepository
    {
        public CategoryItemRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
