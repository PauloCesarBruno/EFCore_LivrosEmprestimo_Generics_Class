using LivrariaControleEmprestimo.DATA.Repository;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroService
    {
        public RepositoryLivro oRepositoryLivro { get; set; }

        public LivroService()
        {
            oRepositoryLivro = new RepositoryLivro();
        }
    }
}
