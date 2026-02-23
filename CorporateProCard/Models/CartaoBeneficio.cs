using CorporateProCard.Enum;

namespace CorporateProCard.Models
{
    public class CartaoBeneficio
    {
        public int Id { get; set; } 
        public string NumeroCartao { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal LimiteMensal  { get; set; }
        public decimal SaldoDisponivel { get; set; }
        public StatusCartao Status { get; set; }
        public string? MotivoBloqueio { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
    }
}
