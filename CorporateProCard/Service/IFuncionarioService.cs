using CorporateProCard.Models;

namespace CorporateProCard.Service
{
    public interface IFuncionarioService
    {
        public Funcionario AdmitirFuncionario();
        public Funcionario AtualizarFuncionario();
        public void AlterarSalario(int funcionarioId, decimal novoSalario);
        public void InativarFuncionario(int funcionarioId);
        public void ReativarFuncionario(int funcionarioId);
        public void DesligarFuncionario(int funcionarioId);
        public Funcionario ObterFuncionarioPorId(int funcionarioId);
        public IEnumerable<Funcionario> ObterTodosFuncionarios();

    }
}
