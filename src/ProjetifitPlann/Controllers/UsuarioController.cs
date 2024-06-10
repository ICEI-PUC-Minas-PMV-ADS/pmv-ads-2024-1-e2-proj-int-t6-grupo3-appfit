using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjetifitPlann.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace ProjetifitPlann.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AplicationDbContext _context;

        

        public UsuarioController(AplicationDbContext context )
        {
            _context = context;
           
        }

        // GET: Registro
        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        // POST: Registro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registro(Usuario model)
        {
            if (ModelState.IsValid)
            {
                var usuarioExistente = _context.Usuarios.Any(u => u.Email == model.Email);
                if (usuarioExistente)
                {
                    ModelState.AddModelError("Email", "Email já cadastrado.");
                    return View(model);
                }

                model.Senha = BCrypt.Net.BCrypt.HashPassword(model.Senha);
                _context.Usuarios.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(model);
        }

        // GET: Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (usuario != null && BCrypt.Net.BCrypt.Verify(model.Senha, usuario.Senha))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, usuario.Nome),
                        new Claim(ClaimTypes.Email, usuario.Email)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.LembrarMe
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Email ou senha inválidos.");
            }
            return View(model);
        }
        //GET: Logout
        [HttpGet]
        public IActionResult Sair()
        {
            return RedirectToAction("Login", "Usuario");
        }
        // POST: Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Usuario");
        }
    }
}
