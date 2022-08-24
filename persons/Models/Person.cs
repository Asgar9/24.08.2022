using System;
using System.Collections.Generic;
using System.Text;

namespace persons.Models
{
       abstract class Person
    {
        private int _id;

        public int Id {get { return _id; }}

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        /*public int Point { get; set; }*///bunun burda olmasi deqiq deyil
        public void ShowInfo()
        {
            //persondan miras alan classlarin butun melumatlarini geri qaytarir.
        }
        public Person(string Name,string SurName)
        {
            this.Name = Name;
            this.SurName = SurName;
                _id++;
        }

        
    }
}
