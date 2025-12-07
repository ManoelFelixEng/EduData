using System;

namespace EduData.App.ViewModel
{
    public class StudentViewModel
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Birth { get; set; }
        public int Id_class { get; set; } // chave estrangeira

        
        public string ClassName { get; set; }
    }
}