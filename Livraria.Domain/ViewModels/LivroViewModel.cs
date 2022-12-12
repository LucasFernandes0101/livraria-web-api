namespace Livraria.Domain.ViewModels
{
    public class LivroViewModel
    {
        public Guid Id { get; set; }
        public Guid AutorId { get; set; }
        public string? Titulo { get; set; }
        public int QtdPaginas { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
