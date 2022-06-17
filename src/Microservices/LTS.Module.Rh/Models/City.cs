using LTS.RH.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Rh.Models
{
    public class City : EntityBase
    {
        public City(long id)
        {
            Id = id;
        }

        public string StateOrProvinceId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }

        public string Code { get; set; }

        public string CityName { get; set; }
    }
}
