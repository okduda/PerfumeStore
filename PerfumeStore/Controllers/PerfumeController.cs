using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfumeStore.Controllers
{
    public class PerfumeController: Controller
    {
        private IPerfumeService _perfumeService;

        public PerfumeController(IPerfumeService perfumeService)
        {
            _perfumeService = perfumeService;
        }

        public IActionResult Index()
        {
            List<PerfumeViewModel> perfumeViewModelList = _perfumeService.GetAll().ToList();

            return View(perfumeViewModelList);
        }

        [HttpPost]
        public IActionResult SavePerfume(PerfumeViewModel perfumeViewModel)
        {
            _perfumeService.SavePerfume(perfumeViewModel);

            return RedirectToAction("PerfumeForm");
        }

        [HttpPost]
        public IActionResult UpdatePerfume(PerfumeViewModel perfumeViewModel)
        {
            _perfumeService.UpdatePerfume(perfumeViewModel);

            return RedirectToAction("Index");
        }

        public IActionResult DeletePerfume(Guid id)
        {
            _perfumeService.DeletePerfumeById(id);

            return RedirectToAction("Index");
        }

        public IActionResult PerfumeForm(Guid id)
        {
            PerfumeFormViewModel perfumeFormViewModel = new PerfumeFormViewModel();
            PerfumeViewModel perfumeViewModel;

            List<string> perfumeList = new List<string>();
            perfumeList.Add("Hot Couture");
            perfumeList.Add("Miss Dior");
            perfumeList.Add("Chanel 5");

            perfumeFormViewModel.PerfumeList = perfumeList;

            if (id == Guid.Empty)
            {
                perfumeViewModel = new PerfumeViewModel();
            }
            else
            {
                perfumeViewModel = _perfumeService.GetPerfumeViewModelById(id);
            }

            perfumeFormViewModel.Perfume = perfumeViewModel;

            return View(perfumeFormViewModel);
        }
    }
}