using AztuChat.DAL;
using AztuChat.Models;
using AztuChat.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace AztuChat.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AccountController(UserManager<AppUser> userManager,IWebHostEnvironment env,AppDbContext context)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
       public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            AppUser user = new AppUser
            {
                UserName = register.UserName,
                
            };
           await _userManager.CreateAsync(user, register.PassWord);
            string fileName = register.UserName + register.Image.FileName;
            using (FileStream fs = new FileStream(Path.Combine(_env.WebRootPath,"img",fileName),FileMode.Create))
            {
                register.Image.CopyTo(fs);
            }
            UserImage ui = new UserImage
            {
                ImageUrl = fileName,
                User = user
            };
            await _context.userImages.AddAsync(ui);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Login));
        }

     
    }
}
