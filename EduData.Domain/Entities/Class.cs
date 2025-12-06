using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduData.Domain.Base;

namespace EduData.Domain.Entities
{
    public class Class : BaseEntity<int>
    {


        public Class() { 
        
        }
        public Class(int id,int period,string course,int number_students ) : base(id)
        {
            Period = period;
            Course = course;
            Number_students = number_students;
        }

        public int Period { get; set; }
        public string Course { get; set; }
        public int Number_students {  get; set; }
    }
}
