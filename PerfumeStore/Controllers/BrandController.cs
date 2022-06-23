using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfumeStore.Controllers
{
    public class BrandController : Controller
    {
        private IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            List<BrandViewModel> brandViewModelList = _brandService.GetAll().ToList();

            return View(brandViewModelList);  
        }

        [HttpPost]
        public IActionResult SaveBrand(BrandViewModel brandViewModel)
        {
            _brandService.SaveBrand(brandViewModel);

            return RedirectToAction("BrandForm");
        }
        
        [HttpPost]
        public IActionResult UpdateBrand(BrandViewModel brandViewModel)
        {
            _brandService.UpdateBrand(brandViewModel);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteBrand(Guid id)
        {
            _brandService.DeleteBrandById(id);

            return RedirectToAction("Index");
        }

        public IActionResult BrandForm(Guid id)
        {
            BrandFormViewModel brandFormViewModel = new BrandFormViewModel();
            BrandViewModel brandViewModel;

            List<string> countryList = new List<string>();
            countryList.Add("Spain");
            countryList.Add("France");
            countryList.Add("Italy");

            brandFormViewModel.CountryList = countryList;

            if(id == Guid.Empty)
            {
                brandViewModel = new BrandViewModel();
            }
            else
            {
                brandViewModel = _brandService.GetBrandViewModelById(id);
            }

            brandFormViewModel.Brand = brandViewModel;

            return View(brandFormViewModel);
        }
    }
}
