using CorporateProCard.Enum;
using System.Security.Cryptography.X509Certificates;

namespace CorporateProCard.Models
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; private set; }
        public decimal Salario { get; private set; }
        public string Cargo { get; private set; }
        public StatusFuncionario Status { get; private set; }
        public NivelAcesso NivelAcesso { get; private set; }
        public CartaoBeneficio Cartao { get; private set; }

        public void ConcederCartao()
        {
            if ((Cartao == null || Cartao.Status == StatusCartao.Bloqueado) && Status == StatusFuncionario.Ativo && this.DataAdmissao <= DateTime.Now.AddMonths(-3) && Salario > 2000m)
            {
                Cartao = new CartaoBeneficio(this);
            }
            else
            {
                throw new InvalidOperationException("Funcionário não possui critérios válidos para cartão benefício");
            }
        }

        public void Inativar() 
        {
            Status = StatusFuncionario.Inativo;

            if (Cartao != null)
            {
               Cartao.Bloquear("Funcionário inativado");
            }
        }
    }
}
