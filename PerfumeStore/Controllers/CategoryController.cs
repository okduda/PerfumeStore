using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfumeStore.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            List<CategoryViewModel> categoryViewModelList = _categoryService.GetAll().ToList();
           
            return View(categoryViewModelList);
        }

        public IActionResult CategoryForm(Guid id)
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();

            if (id != Guid.Empty)
            {
                categoryViewModel = _categoryService.GetCategoryViewModelById(id);                             
            }

            return View(categoryViewModel);
        } 

        public IActionResult SaveCategory(CategoryViewModel categoryViewModel)
        {
            _categoryService.SaveCategory(categoryViewModel);

            return RedirectToAction("CategoryForm");
        }

        public IActionResult UpdateCategory(CategoryViewModel categoryViewModel)
        {
            _categoryService.UpdateCategory(categoryViewModel);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(Guid id)
        {
            _categoryService.DeleteCategoryById(id);

            return RedirectToAction("Index");
        }
    }
}
