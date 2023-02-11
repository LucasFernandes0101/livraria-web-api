using Livraria.Domain.Base.Interfaces;

namespace Livraria.Domain.Base.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; } = new Guid();
        public bool Active { get; set; } = true;
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
