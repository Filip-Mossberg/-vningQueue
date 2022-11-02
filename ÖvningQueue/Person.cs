using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueue
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public int Id { get; set; }

        public Person(string _Name, int _Age, char _Gender, int _Id)
        {
            this.Name = _Name;
            this.Age = _Age;
            this.Gender = _Gender;
            this.Id = _Id;
        }
    }
}
