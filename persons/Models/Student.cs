using System;
using System.Collections.Generic;
using System.Text;

namespace persons.Models
{
     class Student:Person
    {
        public Student(string Name, string SurName, int Point) : base(Name, SurName)
        {
            this.Point = Point;
        }

        public int Point { get; set; }
        //> ve < operatorlari ucun overloading yazmaliyiq ve Point Deyerlerini muqayise edirik;
    }
}
