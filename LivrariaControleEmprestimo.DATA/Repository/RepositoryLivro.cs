using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repository
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanches = true) : base(SaveChanches)
        {

        }
    }
}
