using System.Collections.Generic;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> SelecionarTodos();
        T SelecionarPk(params object[] variavel);
        T Incluir(T objeto);
        T Alterar(T objeto);
        void Excluir(T objeto); // Não preciso retornar nada ao Excluir
        void Excluir(params object[] variavel); // Não preciso retornar nada ao Excluir
        void SaveChanges();
    }
}
