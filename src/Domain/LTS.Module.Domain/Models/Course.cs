using LTS.Module.Persistence.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Domain.Models
{
    public class Course : EntityBase
    {
        public Course(long id)
        {
            Id = id;
        }
        
        public string CourseName { get; set; }
    }
}
