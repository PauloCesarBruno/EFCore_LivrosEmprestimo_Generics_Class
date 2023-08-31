using LivrariaControleEmprestimo.DATA.Repository;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public ReposytoriVwLivroClienteEmprestimo oReposytoriVwLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }
        public ReposytoriLivroClienteEmprestimo oReposytoriLivroClienteEmprestimo { get; set; }

        public LivroClienteEmprestimoService()
        {
            oReposytoriVwLivroClienteEmprestimo = new ReposytoriVwLivroClienteEmprestimo();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryCliente = new RepositoryCliente();
            oReposytoriLivroClienteEmprestimo = new ReposytoriLivroClienteEmprestimo();
        }
    }
}
