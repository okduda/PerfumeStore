using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
