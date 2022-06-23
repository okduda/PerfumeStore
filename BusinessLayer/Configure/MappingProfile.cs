using AutoMapper;
using BusinessLayer.ViewModels;
using DAL.Entities;

namespace BusinessLayer.Configure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, BrandViewModel>();
            CreateMap<BrandViewModel, Brand>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
            CreateMap<User, UserViewModel>().ForMember(x => x.Role, opt => opt.Ignore());
            CreateMap<UserViewModel, User>().ForMember(x => x.Role, opt => opt.Ignore()); ;
            CreateMap<Role, RoleViewModel>();
            CreateMap<RoleViewModel, Role>();
            CreateMap<Perfume, PerfumeViewModel>();
            CreateMap<PerfumeViewModel, Perfume>();
        }
    }
}
