using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();

        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {                                        
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            Cliente objCliente = oClienteService.oRepositoryCliente.SelecionarPk(Id);
            return View(objCliente);
        }

        public IActionResult Edit(int Id)
        {
            Cliente objCliente = oClienteService.oRepositoryCliente.SelecionarPk(Id);
            return View(objCliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente objCliente = oClienteService.oRepositoryCliente.Alterar(model);

            // Redirecionamento...
            int Id = objCliente.Id;
            return RedirectToAction("Details", new { Id });
        }

        public IActionResult Delete(int Id)
        {
            try
            {
                /* Não vou usar partial View nem retornar nehuma view vou usar 
                * o Botstrap Modal e retornar para Index Mesmo.*/
                oClienteService.oRepositoryCliente.Excluir(Id);
                return RedirectToAction("Index");
            }
            catch 
            {
                return View("Tratamento");
            }
           
        }
    }
}