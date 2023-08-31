using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(int? Id)
        {
            if (Id != null)
            {
                if (Id == 0)
                {
                    HttpContext.Session.SetString("IdLogado", string.Empty);
                    HttpContext.Session.SetString("NomeLogado", string.Empty);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(ModelLogin login)
        {
            if (ModelState.IsValid)
            {
                bool loginOK = login.ValidarLogin();
                if (loginOK)
                {
                    HttpContext.Session.SetString("IdLogado", login.Id);
                    HttpContext.Session.SetString("NomeLogado", login.Nome);
                    // Rota para Emprestimo...
                    return RedirectToAction("Index", "Emprestimos");
                }
                else
                {
                    TempData["ErrorMessage"] = "Email e/ou Senha Incoreto(s) !";
                }
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
