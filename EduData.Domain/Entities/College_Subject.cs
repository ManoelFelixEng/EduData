using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduData.Domain.Base;

namespace EduData.Domain.Entities
{
    public class College_Subject : BaseEntity<int>
    {

        public College_Subject()
        {

        }
        public College_Subject(int id,string name, int courseload  ) : base(id)
        {
           Name = name;
           Courseload = courseload;
        }
        public string Name { get; set; }
        public int Courseload { get; set; }

        
    }
}
