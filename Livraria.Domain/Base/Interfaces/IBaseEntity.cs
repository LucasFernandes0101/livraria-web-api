using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
