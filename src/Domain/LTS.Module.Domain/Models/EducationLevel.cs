using LTS.Module.Persistence.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Domain.Models
{
    public class EducationLevel : EntityBase
    {
        public EducationLevel(long id)
        {
            Id = id;
        }

        public string Description { get; set; }
    }
}
