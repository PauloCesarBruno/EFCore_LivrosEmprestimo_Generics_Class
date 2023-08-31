using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repository
{
    public class ReposytoriVwLivroClienteEmprestimo : RepositoryBase<VwLivroClienteEmprestimo>, IReposytoriVwLivroClienteEmprestimo
    {
        public ReposytoriVwLivroClienteEmprestimo(bool SaveChanches = true) : base(SaveChanches)
        {

        }
    }
}
