using LivrariaControleEmprestimo.DATA.Repository;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class EmprestimoService
    {
        public ReposytoriLivroClienteEmprestimo oRLce { get; set; }

        public EmprestimoService()
        {
            oRLce = new ReposytoriLivroClienteEmprestimo();
        }
    }
}
