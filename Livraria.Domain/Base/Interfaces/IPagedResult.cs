namespace Livraria.Domain.Base.Interfaces
{
    public interface IPagedResult<T>
    {
        int Total { get; }
        List<T> Items { get; }
    }
}
