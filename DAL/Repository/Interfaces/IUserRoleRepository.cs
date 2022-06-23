using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public interface IUserRoleRepository : IBaseRepository<UserRole>
    {
        UserRole GetByUserId(Guid id);
    }
}
