using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_prac
{
    class Student
    {
        public int ID;
        public string Name;
        public string Description;
        
        Student(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }

        public Student() {
            this.ID = 0;
            this.Name = "John Doe";
            this.Description = "5'6'' white 155 pounds";
        }

        public Student(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = string.Empty;
        }
    }
}
