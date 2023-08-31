using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.DATA.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanches = true) : base(SaveChanches)
        {

        }
    }
}
