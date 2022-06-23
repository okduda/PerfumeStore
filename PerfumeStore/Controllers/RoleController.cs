using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfumeStore.Controllers
{
    public class RoleController : Controller
    {
        private IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            List<RoleViewModel> roleViewModelList = _roleService.GetAll().ToList();

            return View(roleViewModelList);
        }

        [HttpGet]
        public IActionResult RoleForm(Guid id)
        {
            RoleViewModel roleViewModel;

            if (id == Guid.Empty)
            {
                roleViewModel = new RoleViewModel();
            }
            else
            {
                roleViewModel = _roleService.GetRoleViewModelById(id);
            }

            return View(roleViewModel);
        }

        [HttpPost]
        public IActionResult SaveRole(RoleViewModel roleViewModel)
        {
            _roleService.SaveRole(roleViewModel);

            return RedirectToAction("RoleForm");
        }


        [HttpPost]
        public IActionResult DeleteRole(Guid id)
        {
            _roleService.DeleteRoleById(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateRole(RoleViewModel roleViewModel)
        {
            _roleService.UpdateRole(roleViewModel);

            return RedirectToAction("Index");
        }
    }
}