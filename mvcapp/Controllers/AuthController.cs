using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcapp.Dto;
using mvcapp.Models;

namespace mvcapp.Controllers
{
    public class AuthController(AppDbContext _context) : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();

        }
        public IActionResult LoginToRegister()
        {
            return RedirectToAction("Registration");
        }

        public IActionResult RegisterToLogin()
        {
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> RegisterUser(UserDto dto)
        {
            if (dto == null)
            {
                ViewBag.Message = "Please provide email ans password";
                return View("Login");
            }
            if (dto.Email == null || dto.Password == null)
            {
                ViewBag.Message = "Email and Password are required";
                return View("Login");

            }
            var data = await _context.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (data != null)
            {
                ViewBag.Message = "Email already Exists";
                return View("Registration");
            }
            _context.Users.Add(new User
            {
                Username = dto.Username,
                Password = dto.Password,
                Email = dto.Email

            });
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");



        }

        public IActionResult LoginUser(UserDto dto)
        {
            if (dto == null)
            {
                ViewBag.Message = "Please provide email ans password";
                return View("Login");
            }
            if (dto.Email == null || dto.Password == null)
            {
                ViewBag.Message = "Email and Password are required";
                return View("Login");

            }

            var isExist = _context.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (isExist == null)
            {
                ViewBag.Message = "Email does not Exist";
                return View("Login");

            }
            if (isExist.Result.Password != dto.Password)
            {
                ViewBag.Message = "Incorrect Password";
                return View("Login");
            }
            return RedirectToAction("Index", "Dashboard");



        }


    }
}