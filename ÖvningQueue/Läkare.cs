using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueue
{
    internal class Läkare : Person
    {
        public int Salary { get; set; }
        public double Worktime { get; set; }
        public Läkare(string _Name, int _Age, char _Gender, int _Id, int _Salary, double _Worktime) : base(_Name, _Age, _Gender, _Id)
        {
            Salary = _Salary;
            Worktime = _Worktime;
        }

        public void PrintRecipe()
        {

        }
    }
}
