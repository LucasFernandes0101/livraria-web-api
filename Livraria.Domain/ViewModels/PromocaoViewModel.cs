namespace Livraria.Domain.ViewModels
{
    public class PromocaoViewModel
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public Guid LivroId { get; set; }
    }
}
