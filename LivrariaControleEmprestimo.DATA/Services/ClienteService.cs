using LivrariaControleEmprestimo.DATA.Repository;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
