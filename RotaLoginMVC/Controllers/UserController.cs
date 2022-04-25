using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RotaLoginMVC.Models;
using System.Threading.Tasks;

namespace RotaLoginMVC.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            ApplicationUser appUser = new ApplicationUser
            {
                UserName = user.Name,
                Email = user.Email
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);

            if (result.Succeeded)
            {
                ViewBag.Message = "Usuário Cadastrado Com Sucesso";
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(UserRole userRole)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _roleManager.CreateAsync(new ApplicationRole() { Name = userRole.RoleName });
                if (result.Succeeded)
                {
                    ViewBag.Message = "Função criada com sucesso";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }
    }
}
