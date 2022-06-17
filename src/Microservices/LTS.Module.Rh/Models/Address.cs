using LTS.RH.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Rh.Models
{
    public class Address : EntityBase
    {
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int StateOrProvinceId { get; set; }

        public StateOrProvince stateOrProvince { get; set; }


        public int CityId { get; set; }

        public City City { get; set; }

        public string Neighborhood { get; set; }

        public string ZipCode { get; set; }

        public string Description { get; set; }

        public int? Number { get; set; }

        public string Complement { get; set; }
    }
}
