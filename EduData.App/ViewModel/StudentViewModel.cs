using System;

namespace EduData.App.ViewModel
{
    public class StudentViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

       
        public int ClassId { get; set; }      
        public string ClassCourse { get; set; } 
    }
}