using CorporateProCard.Enum;

namespace CorporateProCard.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public string Cargo { get; set; }
        public StatusFuncionario Status { get; set; }
        public NivelAcesso NivelAcesso { get; set; }
        public CartaoBeneficio Cartao { get; set; }
    }
}
