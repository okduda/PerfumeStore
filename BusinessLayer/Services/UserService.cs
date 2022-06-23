using AutoMapper;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using DAL.Entities;
using DAL.Repository.Interfaces;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IUserRoleRepository _userRoleRepository;
        private IRoleRepository _roleRepository;
        private IMapper _mapper;

        public UserService(
            IUserRepository userRepository,
            IUserRoleRepository userRoleRepository,
            IMapper mapper,
            IRoleRepository roleRepository)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        public IEnumerable<UserViewModel> GetAll()
        {
            List<User> userList = _userRepository.GetAll().ToList();

            List<UserViewModel> userViewModelList = _mapper.Map<List<UserViewModel>>(userList);

            foreach (var user in userViewModelList)
            {
                var userRole = _userRoleRepository.GetByUserId(user.Id);
                var role = _roleRepository.GetById(userRole.RoleId);
                user.Role = _mapper.Map<RoleViewModel>(role);
            }

            return userViewModelList;
        }

        public UserViewModel GetUserViewModelById(Guid id)
        {
            User user = _userRepository.GetById(id);
            var roleId = user.Role.SingleOrDefault().RoleId;
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

            var role = _roleRepository.GetById(roleId);
            var roleViewModel = _mapper.Map<RoleViewModel>(role);
            userViewModel.Role = roleViewModel;

            return userViewModel;
        }

        public void DeleteUserById(Guid id)
        {
            _userRepository.DeleteById(id);
        }

        public void SaveUser(UserViewModel userViewModel)
        {
            User user = new User();
            var userRole = new UserRole();
            user.Name = userViewModel.Name;
            user.Email = userViewModel.Email;
            user.Password = userViewModel.Password;
            _userRepository.Add(user);
            userRole.UserId = user.Id;
            userRole.RoleId = userViewModel.Role.Id;
            _userRoleRepository.Add(userRole);
        }

        public void UpdateUser(UserViewModel userViewModel)
        {
            User user = _mapper.Map<User>(userViewModel);

            _userRepository.Update(user);
            UserRole userRole = _userRoleRepository.GetByUserId(userViewModel.Id);
            userRole.RoleId = userViewModel.Role.Id;
            _userRoleRepository.Update(userRole);
        }
    }
}