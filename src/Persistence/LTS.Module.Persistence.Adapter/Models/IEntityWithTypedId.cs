using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Persistence.Adapter.Models
{
    public interface IEntityWithTypedId<TId>
    {
        TId Id { get; }
    }
}
