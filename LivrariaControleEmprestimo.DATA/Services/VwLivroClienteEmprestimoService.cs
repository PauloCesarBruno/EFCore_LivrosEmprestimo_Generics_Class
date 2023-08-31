using LivrariaControleEmprestimo.DATA.Repository;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class VwLivroClienteEmprestimoService
    {
        public ReposytoriVwLivroClienteEmprestimo oReposytoriVwLivroClienteEmprestimo{ get; set; }

        public VwLivroClienteEmprestimoService()
        {
            oReposytoriVwLivroClienteEmprestimo = new ReposytoriVwLivroClienteEmprestimo();
        }
        
    }
}
