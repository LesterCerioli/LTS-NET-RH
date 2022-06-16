using LTS.Module.Persistence.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Domain.Models
{
    public class Dependent : EntityBase
    {

        
        public Dependent(long id)
        {
            Id = id;
        }
        
        public string DependentName { get; set; }

        public string DependentMiddleName { get; set; }

        public string DependentLastName { get; set; }


        public int Kinship { get; set; }


        public bool IsDependentIRRF { get; set; }


        public DateTime dtBirth { get; set; }

        public string TaxPayerRegistry { get; set; }
    }
}
