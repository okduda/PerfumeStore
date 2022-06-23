using AutoMapper;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using DAL.Entities;
using DAL.Repository.Interfaces;

namespace BusinessLayer.Services
{
    public class RoleService : IRoleService
    {
        private IMapper _mapper;
        private IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public IEnumerable<RoleViewModel> GetAll()
        {
            List<Role> roleList = _roleRepository.GetAll().ToList();
            List<RoleViewModel> roleViewModelList = _mapper.Map<List<RoleViewModel>>(roleList);

            return roleViewModelList;
        }

        public void SaveRole(RoleViewModel roleViewModel)
        {
            Role role = new Role();
            role.Name = roleViewModel.Name;
            _roleRepository.Add(role);
        }

        public void DeleteRoleById(Guid id)
        {
            _roleRepository.DeleteById(id);
        }

        public RoleViewModel GetRoleViewModelById(Guid id)
        {
            Role role = _roleRepository.GetById(id);
            RoleViewModel roleViewModel = _mapper.Map<RoleViewModel>(role);

            return roleViewModel;
        }

        public void UpdateRole(RoleViewModel roleViewModel)
        {
            Role role = _mapper.Map<Role>(roleViewModel);
            _roleRepository.Update(role);
        }
    }
}