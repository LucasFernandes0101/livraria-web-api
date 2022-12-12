namespace Livraria.Domain.Base.Interfaces
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        bool Active { get; set; }
        DateTime DataCadastro { get; set; }
        DateTime DataAlteracao { get; set; }
    }
}
