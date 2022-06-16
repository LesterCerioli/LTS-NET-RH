using LTS.Module.Persistence.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Domain.Models
{
    public class Employee : EntityBase
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string TaxPayer { get; set; }
        public DateTime? dtBirth { get; set; }
        public int? GenderId { get; set; }
        public int? Deficient { get; set; }
        public int? Race { get; set; }
        public int MaritalStatusId { get; set; }
        public int CountryBirth { get; set; }
        public int UfBirth { get; set; }
        public int CityBirth { get; set; }
        public int EducationLevelId { get; set; }
        public string InstitutionEducational { get; set; }
        public int Course { get; set; }
        public string NationalRegistry { get; set; }

        public Address Address { get; set; }

        //public Email Email { get; set; }
        public GeneralRegistration GenRegister { get; set; }

        public MilitaryEnlistment CertMilitary { get; set; }

        public PIS PIS { get; set; }

        public WorkPermit WorkPermit { get; set; }

        public VotersTitle VoteTitle { get; set; }

        public List<Phone> Phones { get; set; }

        //public BankAccount BankAccount { get; set; }

        //public List<Benefit> Benefits { get; set; }
        public List<Parent> Parents { get; set; }

        public List<Dependent> Dependents { get; set; }
    }
}
