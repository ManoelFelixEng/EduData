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
        public Class()
        {
        }

        public Class(int id, int period, string? course, int numberStudents) : base(id)
        {
            Period = period;
            Course = course;
            NumberStudents = numberStudents;
        }

        public int Period { get; set; } 
        public string? Course { get; set; } 
        public int NumberStudents { get; set; } 
    }
}