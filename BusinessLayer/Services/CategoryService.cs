using AutoMapper;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using DAL.Entities;
using DAL.Repository.Interfaces;

namespace BusinessLayer.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            List<Category> categoryList = _categoryRepository.GetAll().ToList();
            List<CategoryViewModel> categoryViewModels = _mapper.Map<List<CategoryViewModel>>(categoryList);

            return categoryViewModels;
        }

        public CategoryViewModel GetCategoryViewModelById(Guid id)
        {
            Category category = _categoryRepository.GetById(id);
            CategoryViewModel categoryViewModel = _mapper.Map<CategoryViewModel>(category);

            return categoryViewModel;
        }

        public void DeleteCategoryById(Guid id)
        {
            _categoryRepository.DeleteById(id);
        }

        public void SaveCategory(CategoryViewModel categoryViewModel)
        {
            Category category = new Category();
            category.Name = categoryViewModel.Name;
            _categoryRepository.Add(category);
        }

        public void UpdateCategory(CategoryViewModel categoryViewModel)
        {
            Category category = _mapper.Map<Category>(categoryViewModel);
            _categoryRepository.Update(category);
        }
    }


}
