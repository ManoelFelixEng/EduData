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

        public Student(int id, string name, DateTime dateBirth, Class @class) : base(id)
        {
            Name = name;
            DateBirth = dateBirth;
            Class = @class;
        }

        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        // Propriedade de Navegação (O Objeto Turma, não só o ID)
        public Class Class { get; set; }
    }
}