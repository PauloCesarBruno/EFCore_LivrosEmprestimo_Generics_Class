using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroService oLivroService = new LivroService();

        public IActionResult Index()
        {
            List<Livro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            Livro objLivro = oLivroService.oRepositoryLivro.SelecionarPk(Id);
            return View(objLivro);
        }

        public IActionResult Edit(int Id)
        {
            Livro objLivro = oLivroService.oRepositoryLivro.SelecionarPk(Id);
            return View(objLivro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            Livro objLivro = oLivroService.oRepositoryLivro.Alterar(model);

            // Redirecionar para o Edit...
            int Id = objLivro.Id;
            return RedirectToAction("Details", new { Id });
        }

        public IActionResult Delete(int Id)
        {
            try
            {
                /* Não vou usar partial View nem retornar nehuma view vou usar 
                 * o Botstrap Modal e retornar para Index Mesmo.*/
                oLivroService.oRepositoryLivro.Excluir(Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Tratamento");
            }
        }
    }
}

