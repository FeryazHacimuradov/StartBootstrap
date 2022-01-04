using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StartBootStrap.Data;
using StartBootStrap.Models;
using StartBootStrap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _singInManager;


        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> singInManager)
        {
            _context = context;
            _userManager = userManager;
            _singInManager = singInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> register(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = new CustomUser()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    PhoneNumber = model.Phone,
                    Address = model.Address,
                    Email = model.Email,
                    UserName = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _singInManager.SignInAsync(user, false);
                    return RedirectToAction("index", "home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

            }
            return View(model);
    }

    public IActionResult Login()
        {
            return View();
        }
    }
}
