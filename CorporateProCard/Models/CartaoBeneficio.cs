using CorporateProCard.Enum;
using System.Data;

namespace CorporateProCard.Models
{
    public class CartaoBeneficio
    {
        public CartaoBeneficio(Funcionario funcionario)
        {
            switch (funcionario.NivelAcesso)
            {
                case NivelAcesso.Junior:
                    LimiteMensal = 500m;
                    break;
                case NivelAcesso.Pleno:
                    LimiteMensal = 800m;
                    break;
                case NivelAcesso.Senior:
                    LimiteMensal = 1200m;
                    break;
                case NivelAcesso.Diretor:
                    LimiteMensal = 2000m;
                    break;
            }
            Status = StatusCartao.Ativo;
        }
        public int Id { get; private set; } 
        public string NumeroCartao { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public DateTime DataValidade { get; private set; }
        public decimal LimiteMensal  { get; private set; }
        public decimal SaldoDisponivel { get; private set; }
        public StatusCartao Status { get; private set; }
        public string? MotivoBloqueio { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public int FuncionarioId { get; private set; }

        public void Bloquear(string motivo)
        {
            if(Status == StatusCartao.Bloqueado)
            {
                throw  new InvalidOperationException("Cartão já está bloqueado");
            }
            Status = StatusCartao.Bloqueado;
            MotivoBloqueio = motivo;
        }

    }
}
