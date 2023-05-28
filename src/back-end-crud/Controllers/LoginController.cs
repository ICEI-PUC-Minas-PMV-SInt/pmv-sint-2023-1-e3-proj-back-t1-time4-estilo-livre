using back_end_crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace back_end_crud.Controllers
{
    public class LoginController: Controller
    {
        private readonly ILogger<LoginController> _logger;

        private readonly UsuariosContext _context;

        public LoginController(ILogger<LoginController> logger, UsuariosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]

        public ActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = _context.Usuarios.FirstOrDefault(u => u.Senha == loginModel.Login && u.OfficeLocation == loginModel.Senha);

                    if (usuario != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos");
                    }
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = "Não foi possível realizar o seu Login. Tente novamente";
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
