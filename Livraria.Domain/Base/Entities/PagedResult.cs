using Livraria.Domain.Base.Interfaces;

namespace Livraria.Domain.Base.Entities
{
    public class PagedResult<T> : IPagedResult<T>
    {
        public int Total { get; set; }

        public List<T> Items { get; set; }

        public PagedResult(int total, List<T> items)
        {
            Total = total;
            Items = items;
        }
    }
}
