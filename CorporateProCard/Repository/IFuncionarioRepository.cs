using CorporateProCard.Models;

namespace CorporateProCard.Repository
{
    public interface IFuncionarioRepository
    {
         void Adicionar(Funcionario funcionario);
         void Atualizar(Funcionario funcionario);
         Funcionario ObterPorId(int id);
         IEnumerable<Funcionario> ObterTodos();
    }
}
