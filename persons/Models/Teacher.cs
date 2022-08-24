using System;
using System.Collections.Generic;
using System.Text;

namespace persons.Models
{
    class Teacher:Person
    {
        public Teacher(string Name, string SurName) : base(Name, SurName)
        {
        }

        public int Salary { get; set; }
        //> ve < operatorlari ucun overloading yaziriq Salary deyerlerini muqayise edir.;
    }
}
