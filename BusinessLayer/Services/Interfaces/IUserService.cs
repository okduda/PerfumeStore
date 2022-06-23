using BusinessLayer.ViewModels;

namespace BusinessLayer.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetUserViewModelById(Guid id);

        void DeleteUserById(Guid id);

        void SaveUser(UserViewModel userViewModel);

        void UpdateUser(UserViewModel userViewModel);
    }
}
