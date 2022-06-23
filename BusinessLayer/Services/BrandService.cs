using AutoMapper;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using DAL.Entities;
using DAL.Repository.Interfaces;

namespace BusinessLayer.Services
{
    public class BrandService : IBrandService
    {
        private IBrandRepository _brandRepository;
        private IMapper _mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public IEnumerable<BrandViewModel> GetAll()
        {
            List<Brand> brandList = _brandRepository.GetAll().ToList();
            List<BrandViewModel> brandViewModelList = _mapper.Map<List<BrandViewModel>>(brandList);

            return brandViewModelList;
        }

        public void SaveBrand(BrandViewModel brandViewModel)
        {
            Brand brand = new Brand();
            brand.Name = brandViewModel.Name;
            brand.Country = brandViewModel.Country;
            _brandRepository.Add(brand);
        }

        public void DeleteBrandById(Guid id)
        {
            _brandRepository.DeleteById(id);
        }

        public BrandViewModel GetBrandViewModelById(Guid id)
        {
            Brand brand = _brandRepository.GetById(id);
            BrandViewModel brandViewModel = _mapper.Map<BrandViewModel>(brand);

            return brandViewModel;
        }

        public void UpdateBrand(BrandViewModel brandViewModel)
        {
            Brand brand = _mapper.Map<Brand>(brandViewModel);
            _brandRepository.Update(brand);
        }
    }
}


