namespace Ambev.Domain.Entities
{
    public class Cliente :BaseEntity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
