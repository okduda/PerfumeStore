using BusinessLayer.ViewModels;

namespace BusinessLayer.Services.Interfaces
{
    public interface IRoleService
    {
        IEnumerable<RoleViewModel> GetAll();

        RoleViewModel GetRoleViewModelById(Guid id);

        void DeleteRoleById(Guid id);

        void SaveRole(RoleViewModel roleViewModel);

        void UpdateRole(RoleViewModel roleViewModel);
    }
}