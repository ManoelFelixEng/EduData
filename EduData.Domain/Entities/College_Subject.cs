using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduData.Domain.Base;

namespace EduData.Domain.Entities
{
    public class CollegeSubject : BaseEntity<int>
    {
        public CollegeSubject()
        {
        }

        public CollegeSubject(int id, string name, int courseLoad) : base(id)
        {
            Name = name;
            CourseLoad = courseLoad;
        }

        public string Name { get; set; }
        public int CourseLoad { get; set; }
    }
}