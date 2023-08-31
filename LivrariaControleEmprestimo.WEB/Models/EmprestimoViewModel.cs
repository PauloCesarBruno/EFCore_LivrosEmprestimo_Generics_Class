using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public int idCliente { get; set; }
        public Cliente oCliente { get; set; }

        public int idLivro { get; set; }
        public Livro oLivro { get; set; }

        [Display(Name ="Retirada")]
        [DataType(DataType.Date)]
        public DateTime dataEmprestimo { get; set; }

        [Display(Name = "Devolução")]
        [DataType(DataType.Date)]
        public DateTime dataEntrega { get; set; }

        public List<Cliente> oListCliente { get; set; }

        public List<Livro> oListLivro { get; set; }
    }
}
