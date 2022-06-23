using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();

        CategoryViewModel GetCategoryViewModelById(Guid id);

        void DeleteCategoryById(Guid id);

        void SaveCategory(CategoryViewModel categoryViewModel);

        void UpdateCategory(CategoryViewModel categoryViewModel);
    }
}
