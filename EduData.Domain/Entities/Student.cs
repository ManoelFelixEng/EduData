using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduData.Domain.Base;

namespace EduData.Domain.Entities
{
    public class Student : BaseEntity<int>
    {

        public Student()
        {

        }
       

        public Student(int id, string name, int idClass, DateTime dateBirth) : base(id)
        {
            Name = name;
            Id_class = idClass;
            Date_Birth = dateBirth;
        }
        public string Name { get; set; }
        public DateTime Date_Birth { get; set; }

        //cHAVE ESTRANGEIRA
        public int Id_class { get; set; }
        


    }
}


