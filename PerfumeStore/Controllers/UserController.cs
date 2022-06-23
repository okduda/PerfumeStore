using BusinessLayer.Services.Interfaces;
using BusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfumeStore.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        private IRoleService _roleService;
        public UserController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            List<UserViewModel> userViewModelList = _userService.GetAll().ToList();

            return View(userViewModelList);
        }

        [HttpGet]
        public IActionResult UserForm(Guid id)
        {
            UserFormViewModel userFormViewModel = new UserFormViewModel();
            UserViewModel userViewModel;
                       
            if (id == Guid.Empty)
            {
                userViewModel = new UserViewModel();
            }
            else
            {
                userViewModel = _userService.GetUserViewModelById(id);
            }

            userFormViewModel.User = userViewModel;
            userFormViewModel.UserRoleList = _roleService.GetAll().ToList();

            return View(userFormViewModel);
        }

        [HttpPost]
        public IActionResult SaveUser(UserViewModel userViewModel)
        {
            _userService.SaveUser(userViewModel);

            return RedirectToAction("UserForm");
        }

        [HttpPost]
        public IActionResult UpdateUser(UserViewModel userViewModel)
        {
            _userService.UpdateUser(userViewModel);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteUser(Guid id)
        {
            _userService.DeleteUserById(id);

            return RedirectToAction("Index");
        }
    }
}