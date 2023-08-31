using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repository
{
    public class ReposytoriLivroClienteEmprestimo : RepositoryBase<LivroClienteEmprestimo>, IReposytoriLivroClienteEmprestimo
    {
        public ReposytoriLivroClienteEmprestimo(bool SaveChanches = true) : base(SaveChanches)
        {

        }
    }
}
