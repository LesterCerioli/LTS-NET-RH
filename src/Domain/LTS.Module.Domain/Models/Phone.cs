using LTS.Module.Domain.Enums;
using LTS.Module.Persistence.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Domain.Models
{
    public class Phone : EntityBase
    {
        public int CountryCode { get; set; }

        public int StateCode { get; set; }

        public int CityCode { get; set; }

        public string Number { get; set; }

        public PhoneType Type { get; set; }

        public string ContactName { get; set; }
    }
}
