using BusinessLayer.ViewModels;

namespace BusinessLayer.Services.Interfaces
{
    public interface IBrandService
    {
        public IEnumerable<BrandViewModel> GetAll();

        void SaveBrand(BrandViewModel brandViewModel);
        void DeleteBrandById(Guid id);
        BrandViewModel GetBrandViewModelById(Guid id);
        void UpdateBrand(BrandViewModel brandViewModel);
    }
}
